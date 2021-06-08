using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace WoH_Site_Downloader
{
    public partial class Sort_Ordner : Form
    {
        private Thread threadCrawler;

        private int crawlSite = 0;

        private delegate void SafeCallDelegate(string text);

        public static bool stopCrawlThread = false;

        public Sort_Ordner()
        {
            InitializeComponent();
            internal_settings.listviewSettings(listView1);
            internal_settings.listviewSettings(listView2);
            dlpage.SelectedIndex = 4;
            toolTip1.SetToolTip(this.button_WOC1, internal_settings.ToolTipTextCopy);
            tags.Hide();
            yaoitags.Hide();
            log.Items.Add("Welcome to the WoH Image Loader");
            log.Items.Add("This Box will Displaye you which Doujinshi is Currently");
            log.Items.Add("in Work or has been Loaded.");
            log.Items.Add("Shoud you get any Problems by Loading please post this log");
            log.Items.Add("");
            log.Items.Add("");
            cancel.Hide();
        }

        /*
         * Folder Dialog box allgemein
         */

        public void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            //<Dialog> Fenster öffnen

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            folderDialog.ShowNewFolderButton = false;

            //Ordner wählen

            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult result = folderDialog.ShowDialog();

            //</ Dialog >

            if (result == DialogResult.OK)
            {
                //----< Selected Folder >----

                //< Selected Path >

                var sPath = folderDialog.SelectedPath;
                if (sender == ordner)
                {
                    path_box.Text = sPath;
                }
                else if (sender == source_folder)
                {
                    source_folder_text.Text = sPath;
                }
                else if (sender == checking_folder)
                {
                    checked_ordner_txt.Text = sPath;
                }

                //</ Selected Path >
                if (sender == ordner)
                {
                    updateListview();
                }
            }
        }

        /*
         * Tab1 listview update
         */

        private void updateListview()
        {
            //Clear listView and collect data <Data>
            listView1.Items.Clear();

            GetOrdnerStruktur listbox = new GetOrdnerStruktur(path_box.Text);

            Thread threadFillList1 = new Thread(new ThreadStart(delegate () { listbox.FillListOrdner(1); }));
            threadFillList1.Start();

            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }

            int totalFolderCount = listbox.GetTotalOrderCount();
            loading load_screen = new loading();
            load_screen.Show();

            while (threadFillList1.IsAlive)
            {
                int current_count = listbox.GetWorkedOrdnercount();
                int current_percent = current_count / totalFolderCount * 100;

                Console.WriteLine(current_percent);

                load_screen.updateProgressBar(current_percent);
                Thread.Sleep(1000);
            }

            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }

            load_screen.Hide();
            load_screen = null;

            //</data>
            //show the result to the User <ShowUser>
            long dateiAnzahl = 0;

            foreach (var ausgabe in listbox.Liste1)
            {
                ListViewItem li = new ListViewItem(ausgabe.Key);
                li.SubItems.Add(ausgabe.Value.DateienAnzahl.ToString());
                li.SubItems.Add(ausgabe.Value.OrdnerPath);
                listView1.Items.AddRange(new ListViewItem[] { li });
                dateiAnzahl += ausgabe.Value.DateienAnzahl;
            }
            ordnerfound.Text = "Folders: " + listbox.Liste1.Keys.Count;
            dateienfound.Text = "Files: " + dateiAnzahl;

            //</ShowUser>
        }

        /*
         * Scan Button Tab 2
         */

        private void scan_button_Click(object sender, EventArgs e)
        {
            compare runjob = new compare();

            int trim = 0;

            if (duplicate_3.Checked)
            {
                trim = 3;
            }
            else if (duplicate_5.Checked)
            {
                trim = 5;
            }
            else if (duplicate_7.Checked)
            {
                trim = 7;
            }

            listView2.Items.Clear();

            runjob.compare_ordner(source_folder_text.Text, checked_ordner_txt.Text, trim);

            int dateiAnzahl = 0;

            foreach (var ausgabe in runjob.compareList)
            {
                ListViewItem listViewItem = new ListViewItem(ausgabe.Key);
                listViewItem.SubItems.Add(ausgabe.Value.DateienAnzahl.ToString());
                listViewItem.SubItems.Add(ausgabe.Value.OrdnerPath);
                listViewItem.Checked = true;
                listView2.Items.AddRange(new ListViewItem[] { listViewItem });
                dateiAnzahl += ausgabe.Value.DateienAnzahl;
            }
            label2.Text = "Folders: " + runjob.compareList.Keys.Count;
            label3.Text = "Files: " + dateiAnzahl;
        }

        /*
         * Delete Button Tab 1
         */

        private void delete_button_find_folder_Click(object sender, EventArgs e)
        {
            internal_settings.AskToDelete(listView1);
            updateListview();
        }

        /*
         * Delete Button Tab 2
         */

        private void button5_Click(object sender, EventArgs e)
        {
            bool update = internal_settings.AskToDelete(listView2);
            if (update == true)
            {
                listView2.Items.Clear();
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string message = "Sollen die verglichenen Ordner in den Source kopiert werden ?";
            string headline = "Kopieren von Ordnern";

            bool erg = internal_settings.BenutzerFrage(headline, message, MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (erg == true)
            {
                GetOrdnerStruktur.CopyFolder(checked_ordner_txt.Text, source_folder_text.Text);
            }
        }

        //Tab 3
        public Dictionary<string, bool> nhentaitagliste { get; private set; }

        public Dictionary<string, bool> yaoitagliste { get; private set; }
        public Dictionary<string, bool> chooselang { get; private set; }

        private void nhentai_CheckStateChanged(object sender, EventArgs e)
        {
            if (nhentai.Checked)
            {
                tags.Show();
            }
            else
            {
                tags.Hide();
            }
        }

        private void yaoiheaven_CheckStateChanged(object sender, EventArgs e)
        {
            if (yaoiheaven.Checked)
            {
                yaoitags.Location = new System.Drawing.Point(34, 106);
                for (int i = 26; i < 251; i++)
                {
                    dlpage.Items.Add(i);
                }
                startPage.Enabled = false;
                yaoitags.Show();
            }
            else
            {
                startPage.Enabled = true;
                yaoitags.Hide();
            }
        }

        private void dlsitebutton_Click(object sender, EventArgs e)
        {
            this.nhentaitagliste = new Dictionary<string, bool>();
            this.yaoitagliste = new Dictionary<string, bool>();
            this.chooselang = new Dictionary<string, bool>();
            this.crawlSite = 0;

            chooselang.Add(all.Name.ToString(), all.Checked);
            chooselang.Add(allinengl.Name.ToString(), allinengl.Checked);
            chooselang.Add(alltags.Name.ToString(), alltags.Checked);
            chooselang.Add(tagengl.Name.ToString(), tagengl.Checked);

            if (nhentai.Checked)
            {
                nhentaitagliste.Add(mature.Name.ToString(), mature.Checked);
                nhentaitagliste.Add(lolicon.Name.ToString(), lolicon.Checked);
                nhentaitagliste.Add("ffm-threesome", ffm.Checked);
                nhentaitagliste.Add("garter-belt", garter.Checked);
                nhentaitagliste.Add(tomboy.Name.ToString(), tomboy.Checked);
                nhentaitagliste.Add("dark-skin", darkskin.Checked);
                nhentaitagliste.Add(yuri.Name.ToString(), yuri.Checked);
                nhentaitagliste.Add("females-only", femalesonly.Checked);
                nhentaitagliste.Add(yaoi.Name.ToString(), yaoi.Checked);
                nhentaitagliste.Add(crossdressing.Name.ToString(), crossdressing.Checked);
                nhentaitagliste.Add(futanari.Name.ToString(), futanari.Checked);
                nhentaitagliste.Add(furry.Name.ToString(), furry.Checked);

                this.crawlSite = 1;
            }
            else if (yaoiheaven.Checked)
            {
                yaoitagliste.Add("/doujinshi/bara-doujinshi/", bara.Checked);
                yaoitagliste.Add("/doujinshi/shota-doujinshi/", yaoishota.Checked);
                yaoitagliste.Add("/doujinshi/cub-doujinshi/", yaoicube.Checked);
                yaoitagliste.Add("/doujinshi/yaoi-doujinshi/", yaoiyaoi.Checked);
                yaoitagliste.Add("/doujinshi/animegamecartoon-doujinshi/", yaoianime.Checked);
                yaoitagliste.Add("/doujinshi/furry-doujinshi/", yaoifurry.Checked);

                this.crawlSite = 2;
            }
            else
            {
                internal_settings.BenutzerFrage("Which Site?", "Please Select a Site", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (this.crawlSite > 0 && savepath.Text.Length > 0)
            {
                cancel.Show();

                int sourcePageId = 0;
                if (this.nhentai.Checked == true)
                {
                    sourcePageId = WoH_Site_Downloader.crawler.PAGENHENTAI;
                }
                else if (this.yaoiheaven.Checked == true)
                {
                    sourcePageId = WoH_Site_Downloader.crawler.PAGEYAOIHAVEN;
                }

                crawler crawlerObj = new crawler(
                    this,
                    sourcePageId,
                    this.savepath.Text,
                    Int32.Parse(startPage.Text),
                    Int32.Parse(dlpage.Text),
                    this.chooselang,
                    this.nhentaitagliste,
                    this.yaoitagliste
                );

                this.threadCrawler = new Thread(
                    () => this.executeCrawlThread(crawlerObj)
                );

                if (this.threadCrawler.IsAlive == false)
                {
                    this.threadCrawler.Start();
                }
            }
            else if (savepath.Text.Length == 0)
            {
                internal_settings.BenutzerFrage("Select Folder", "You have to Select a Folder" + Environment.NewLine + "to Save the Doujinshi", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void saveb_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SavetoDialog = new FolderBrowserDialog();

            SavetoDialog.ShowNewFolderButton = false;

            SavetoDialog.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult SaveToOrdner = SavetoDialog.ShowDialog();

            if (SaveToOrdner == DialogResult.OK)
            {
                savepath.Text = SavetoDialog.SelectedPath;
            }
        }

        private void Maker_Click(object sender, EventArgs e)
        {
            internal_settings.Maker();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            log.Items.Add("Download has been canceled");
            this.cancel.Hide();
            Sort_Ordner.stopCrawlThread = true;
        }

        private void executeCrawlThread(crawler crawlerObject)
        {
            crawlerObject.Loader();
        }

        public void writeToConsole(string text)
        {
            if (this.log.InvokeRequired)
            {
                var d = new SafeCallDelegate(writeToConsole);
                this.log.Invoke(d, new object[] { text });
            }
            else
            {
                this.log.Items.Add(text);
                int visibleItems = this.log.ClientSize.Height / this.log.ItemHeight;
                this.log.TopIndex = Math.Max(this.log.Items.Count - visibleItems + 1, 0);
            }
        }
    }
}