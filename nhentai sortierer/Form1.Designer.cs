namespace WoH_Site_Downloader
{
    partial class Sort_Ordner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage same_folder;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sort_Ordner));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ordnerfound = new System.Windows.Forms.Label();
            this.dateienfound = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ordner = new System.Windows.Forms.Button();
            this.path_box = new System.Windows.Forms.TextBox();
            this.delete_button_find_folder = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.compaer_folder = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Quellen = new System.Windows.Forms.Label();
            this.source_folder = new System.Windows.Forms.Button();
            this.source_folder_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checking_folder = new System.Windows.Forms.Button();
            this.checked_ordner_txt = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.duplicate_7 = new System.Windows.Forms.RadioButton();
            this.duplicate_3 = new System.Windows.Forms.RadioButton();
            this.duplicate_5 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.crawler = new System.Windows.Forms.TabPage();
            this.cancel = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.startPage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dlpage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dlsitebutton = new System.Windows.Forms.Button();
            this.yaoitags = new System.Windows.Forms.GroupBox();
            this.yaoifurry = new System.Windows.Forms.CheckBox();
            this.yaoicube = new System.Windows.Forms.CheckBox();
            this.yaoianime = new System.Windows.Forms.CheckBox();
            this.yaoiyaoi = new System.Windows.Forms.CheckBox();
            this.yaoishota = new System.Windows.Forms.CheckBox();
            this.bara = new System.Windows.Forms.CheckBox();
            this.savepath = new System.Windows.Forms.TextBox();
            this.saveb = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.GroupBox();
            this.tagengl = new System.Windows.Forms.RadioButton();
            this.alltags = new System.Windows.Forms.RadioButton();
            this.allinengl = new System.Windows.Forms.RadioButton();
            this.all = new System.Windows.Forms.RadioButton();
            this.tags = new System.Windows.Forms.GroupBox();
            this.furry = new System.Windows.Forms.CheckBox();
            this.yaoi = new System.Windows.Forms.CheckBox();
            this.darkskin = new System.Windows.Forms.CheckBox();
            this.ffm = new System.Windows.Forms.CheckBox();
            this.futanari = new System.Windows.Forms.CheckBox();
            this.crossdressing = new System.Windows.Forms.CheckBox();
            this.femalesonly = new System.Windows.Forms.CheckBox();
            this.yuri = new System.Windows.Forms.CheckBox();
            this.tomboy = new System.Windows.Forms.CheckBox();
            this.garter = new System.Windows.Forms.CheckBox();
            this.lolicon = new System.Windows.Forms.CheckBox();
            this.mature = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nhentai = new System.Windows.Forms.RadioButton();
            this.yaoiheaven = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Maker = new System.Windows.Forms.ToolStripMenuItem();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.scan_button = new ePOSOne.btnProduct.Button_WOC();
            same_folder = new System.Windows.Forms.TabPage();
            same_folder.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.compaer_folder.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.crawler.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPage)).BeginInit();
            this.yaoitags.SuspendLayout();
            this.settings.SuspendLayout();
            this.tags.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // same_folder
            // 
            same_folder.Controls.Add(this.groupBox5);
            same_folder.Controls.Add(this.groupBox4);
            same_folder.Controls.Add(this.delete_button_find_folder);
            same_folder.Controls.Add(this.listView1);
            same_folder.Location = new System.Drawing.Point(4, 25);
            same_folder.Name = "same_folder";
            same_folder.Padding = new System.Windows.Forms.Padding(3);
            same_folder.Size = new System.Drawing.Size(810, 512);
            same_folder.TabIndex = 0;
            same_folder.Text = "Find Same Folder";
            same_folder.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ordnerfound);
            this.groupBox5.Controls.Add(this.dateienfound);
            this.groupBox5.Location = new System.Drawing.Point(444, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(72, 60);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info Box";
            // 
            // ordnerfound
            // 
            this.ordnerfound.AutoSize = true;
            this.ordnerfound.Location = new System.Drawing.Point(6, 16);
            this.ordnerfound.Name = "ordnerfound";
            this.ordnerfound.Size = new System.Drawing.Size(53, 13);
            this.ordnerfound.TabIndex = 6;
            this.ordnerfound.Text = "Folders: 0";
            // 
            // dateienfound
            // 
            this.dateienfound.AutoSize = true;
            this.dateienfound.Location = new System.Drawing.Point(19, 38);
            this.dateienfound.Name = "dateienfound";
            this.dateienfound.Size = new System.Drawing.Size(40, 13);
            this.dateienfound.TabIndex = 7;
            this.dateienfound.Text = "Files: 0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ordner);
            this.groupBox4.Controls.Add(this.path_box);
            this.groupBox4.Location = new System.Drawing.Point(8, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 51);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Check";
            // 
            // ordner
            // 
            this.ordner.Location = new System.Drawing.Point(6, 19);
            this.ordner.Name = "ordner";
            this.ordner.Size = new System.Drawing.Size(108, 23);
            this.ordner.TabIndex = 0;
            this.ordner.Text = "Select Folder";
            this.ordner.UseVisualStyleBackColor = true;
            this.ordner.Click += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // path_box
            // 
            this.path_box.Location = new System.Drawing.Point(120, 19);
            this.path_box.Name = "path_box";
            this.path_box.ReadOnly = true;
            this.path_box.Size = new System.Drawing.Size(250, 20);
            this.path_box.TabIndex = 1;
            // 
            // delete_button_find_folder
            // 
            this.delete_button_find_folder.AutoEllipsis = true;
            this.delete_button_find_folder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_button_find_folder.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.delete_button_find_folder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delete_button_find_folder.FlatAppearance.BorderSize = 5;
            this.delete_button_find_folder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.delete_button_find_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button_find_folder.Image = global::WoH_Site_Downloader.Properties.Resources.close_button_red1;
            this.delete_button_find_folder.Location = new System.Drawing.Point(675, 82);
            this.delete_button_find_folder.Name = "delete_button_find_folder";
            this.delete_button_find_folder.Size = new System.Drawing.Size(127, 119);
            this.delete_button_find_folder.TabIndex = 5;
            this.delete_button_find_folder.Text = "Delete Selected";
            this.delete_button_find_folder.UseVisualStyleBackColor = false;
            this.delete_button_find_folder.Click += new System.EventHandler(this.delete_button_find_folder_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(120, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(531, 367);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(same_folder);
            this.tabControl1.Controls.Add(this.compaer_folder);
            this.tabControl1.Controls.Add(this.crawler);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 541);
            this.tabControl1.TabIndex = 9;
            // 
            // compaer_folder
            // 
            this.compaer_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.compaer_folder.Controls.Add(this.groupBox6);
            this.compaer_folder.Controls.Add(this.button_WOC1);
            this.compaer_folder.Controls.Add(this.listView2);
            this.compaer_folder.Controls.Add(this.groupBox2);
            this.compaer_folder.Controls.Add(this.groupBox1);
            this.compaer_folder.Controls.Add(this.button5);
            this.compaer_folder.Controls.Add(this.scan_button);
            this.compaer_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compaer_folder.Location = new System.Drawing.Point(4, 25);
            this.compaer_folder.Name = "compaer_folder";
            this.compaer_folder.Padding = new System.Windows.Forms.Padding(3);
            this.compaer_folder.Size = new System.Drawing.Size(810, 512);
            this.compaer_folder.TabIndex = 1;
            this.compaer_folder.Text = "Compare folder";
            this.compaer_folder.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Quellen);
            this.groupBox6.Controls.Add(this.source_folder);
            this.groupBox6.Controls.Add(this.source_folder_text);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.checking_folder);
            this.groupBox6.Controls.Add(this.checked_ordner_txt);
            this.groupBox6.Location = new System.Drawing.Point(30, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(426, 116);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select";
            // 
            // Quellen
            // 
            this.Quellen.AutoSize = true;
            this.Quellen.Location = new System.Drawing.Point(6, 17);
            this.Quellen.Name = "Quellen";
            this.Quellen.Size = new System.Drawing.Size(73, 13);
            this.Quellen.TabIndex = 9;
            this.Quellen.Text = "Source Folder";
            // 
            // source_folder
            // 
            this.source_folder.Location = new System.Drawing.Point(4, 36);
            this.source_folder.Name = "source_folder";
            this.source_folder.Size = new System.Drawing.Size(75, 20);
            this.source_folder.TabIndex = 0;
            this.source_folder.Text = "Source";
            this.source_folder.UseVisualStyleBackColor = true;
            this.source_folder.Click += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // source_folder_text
            // 
            this.source_folder_text.Location = new System.Drawing.Point(85, 36);
            this.source_folder_text.Name = "source_folder_text";
            this.source_folder_text.ReadOnly = true;
            this.source_folder_text.Size = new System.Drawing.Size(323, 20);
            this.source_folder_text.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Folder to check";
            // 
            // checking_folder
            // 
            this.checking_folder.Location = new System.Drawing.Point(6, 79);
            this.checking_folder.Name = "checking_folder";
            this.checking_folder.Size = new System.Drawing.Size(75, 20);
            this.checking_folder.TabIndex = 1;
            this.checking_folder.Text = "Source";
            this.checking_folder.UseVisualStyleBackColor = true;
            this.checking_folder.Click += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // checked_ordner_txt
            // 
            this.checked_ordner_txt.Location = new System.Drawing.Point(85, 78);
            this.checked_ordner_txt.Name = "checked_ordner_txt";
            this.checked_ordner_txt.ReadOnly = true;
            this.checked_ordner_txt.Size = new System.Drawing.Size(323, 20);
            this.checked_ordner_txt.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Window;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.CheckBoxes = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(30, 125);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(624, 367);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(655, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Found Duplicates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Files: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Folders: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.duplicate_7);
            this.groupBox1.Controls.Add(this.duplicate_3);
            this.groupBox1.Controls.Add(this.duplicate_5);
            this.groupBox1.Location = new System.Drawing.Point(462, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check letter";
            // 
            // duplicate_7
            // 
            this.duplicate_7.AutoSize = true;
            this.duplicate_7.Location = new System.Drawing.Point(6, 62);
            this.duplicate_7.Name = "duplicate_7";
            this.duplicate_7.Size = new System.Drawing.Size(132, 17);
            this.duplicate_7.TabIndex = 13;
            this.duplicate_7.Text = "check the first 7 letters";
            this.duplicate_7.UseVisualStyleBackColor = true;
            // 
            // duplicate_3
            // 
            this.duplicate_3.AutoSize = true;
            this.duplicate_3.Checked = true;
            this.duplicate_3.Location = new System.Drawing.Point(6, 22);
            this.duplicate_3.Name = "duplicate_3";
            this.duplicate_3.Size = new System.Drawing.Size(132, 17);
            this.duplicate_3.TabIndex = 9;
            this.duplicate_3.TabStop = true;
            this.duplicate_3.Text = "check the first 3 letters";
            this.duplicate_3.UseVisualStyleBackColor = true;
            // 
            // duplicate_5
            // 
            this.duplicate_5.AutoSize = true;
            this.duplicate_5.Location = new System.Drawing.Point(6, 42);
            this.duplicate_5.Name = "duplicate_5";
            this.duplicate_5.Size = new System.Drawing.Size(132, 17);
            this.duplicate_5.TabIndex = 10;
            this.duplicate_5.Text = "check the first 5 letters";
            this.duplicate_5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::WoH_Site_Downloader.Properties.Resources.close_button_red1;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(660, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 115);
            this.button5.TabIndex = 8;
            this.button5.Text = "Delete Selected";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // crawler
            // 
            this.crawler.Controls.Add(this.cancel);
            this.crawler.Controls.Add(this.log);
            this.crawler.Controls.Add(this.groupBox7);
            this.crawler.Controls.Add(this.dlsitebutton);
            this.crawler.Controls.Add(this.yaoitags);
            this.crawler.Controls.Add(this.savepath);
            this.crawler.Controls.Add(this.saveb);
            this.crawler.Controls.Add(this.settings);
            this.crawler.Controls.Add(this.tags);
            this.crawler.Controls.Add(this.groupBox3);
            this.crawler.Location = new System.Drawing.Point(4, 25);
            this.crawler.Name = "crawler";
            this.crawler.Padding = new System.Windows.Forms.Padding(3);
            this.crawler.Size = new System.Drawing.Size(810, 512);
            this.crawler.TabIndex = 2;
            this.crawler.Text = "Site DL";
            this.crawler.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(535, 455);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 37);
            this.cancel.TabIndex = 30;
            this.cancel.Text = "Cancel Download";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.log.FormattingEnabled = true;
            this.log.HorizontalScrollbar = true;
            this.log.Location = new System.Drawing.Point(405, 106);
            this.log.Name = "log";
            this.log.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.log.Size = new System.Drawing.Size(387, 329);
            this.log.TabIndex = 29;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.startPage);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.dlpage);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(396, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(162, 66);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Download Settings";
            // 
            // startPage
            // 
            this.startPage.Location = new System.Drawing.Point(70, 32);
            this.startPage.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.startPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(75, 20);
            this.startPage.TabIndex = 31;
            this.startPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Download";
            this.toolTip1.SetToolTip(this.label5, "Here you can Select how many pages\r\nshoud be Downloaded\r\n");
            // 
            // dlpage
            // 
            this.dlpage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dlpage.FormattingEnabled = true;
            this.dlpage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.dlpage.Location = new System.Drawing.Point(19, 32);
            this.dlpage.Name = "dlpage";
            this.dlpage.Size = new System.Drawing.Size(42, 21);
            this.dlpage.TabIndex = 26;
            this.toolTip1.SetToolTip(this.dlpage, "Here you can Select how many pages\r\nshoud be Downloaded\r\n");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Start Page";
            this.toolTip1.SetToolTip(this.label4, "Select the start page");
            // 
            // dlsitebutton
            // 
            this.dlsitebutton.BackgroundImage = global::WoH_Site_Downloader.Properties.Resources.Dmgla9mVsAAuXVS_jpg_large;
            this.dlsitebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dlsitebutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dlsitebutton.Location = new System.Drawing.Point(25, 232);
            this.dlsitebutton.Name = "dlsitebutton";
            this.dlsitebutton.Size = new System.Drawing.Size(365, 275);
            this.dlsitebutton.TabIndex = 22;
            this.dlsitebutton.UseVisualStyleBackColor = true;
            this.dlsitebutton.Click += new System.EventHandler(this.dlsitebutton_Click);
            // 
            // yaoitags
            // 
            this.yaoitags.Controls.Add(this.yaoifurry);
            this.yaoitags.Controls.Add(this.yaoicube);
            this.yaoitags.Controls.Add(this.yaoianime);
            this.yaoitags.Controls.Add(this.yaoiyaoi);
            this.yaoitags.Controls.Add(this.yaoishota);
            this.yaoitags.Controls.Add(this.bara);
            this.yaoitags.Location = new System.Drawing.Point(5000, 5000);
            this.yaoitags.Name = "yaoitags";
            this.yaoitags.Size = new System.Drawing.Size(356, 91);
            this.yaoitags.TabIndex = 16;
            this.yaoitags.TabStop = false;
            this.yaoitags.Text = "Tags to Load";
            // 
            // yaoifurry
            // 
            this.yaoifurry.AutoSize = true;
            this.yaoifurry.Location = new System.Drawing.Point(92, 62);
            this.yaoifurry.Name = "yaoifurry";
            this.yaoifurry.Size = new System.Drawing.Size(46, 17);
            this.yaoifurry.TabIndex = 21;
            this.yaoifurry.Text = "Fury";
            this.yaoifurry.UseVisualStyleBackColor = true;
            // 
            // yaoicube
            // 
            this.yaoicube.AutoSize = true;
            this.yaoicube.Location = new System.Drawing.Point(6, 62);
            this.yaoicube.Name = "yaoicube";
            this.yaoicube.Size = new System.Drawing.Size(71, 17);
            this.yaoicube.TabIndex = 20;
            this.yaoicube.Text = "Cub Furry";
            this.yaoicube.UseVisualStyleBackColor = true;
            // 
            // yaoianime
            // 
            this.yaoianime.AutoSize = true;
            this.yaoianime.Location = new System.Drawing.Point(92, 39);
            this.yaoianime.Name = "yaoianime";
            this.yaoianime.Size = new System.Drawing.Size(142, 17);
            this.yaoianime.TabIndex = 15;
            this.yaoianime.Text = "Anime / Game / Cartoon";
            this.yaoianime.UseVisualStyleBackColor = true;
            // 
            // yaoiyaoi
            // 
            this.yaoiyaoi.AutoSize = true;
            this.yaoiyaoi.Location = new System.Drawing.Point(92, 16);
            this.yaoiyaoi.Name = "yaoiyaoi";
            this.yaoiyaoi.Size = new System.Drawing.Size(47, 17);
            this.yaoiyaoi.TabIndex = 14;
            this.yaoiyaoi.Text = "Yaoi";
            this.yaoiyaoi.UseVisualStyleBackColor = true;
            // 
            // yaoishota
            // 
            this.yaoishota.AutoSize = true;
            this.yaoishota.Location = new System.Drawing.Point(6, 39);
            this.yaoishota.Name = "yaoishota";
            this.yaoishota.Size = new System.Drawing.Size(72, 17);
            this.yaoishota.TabIndex = 13;
            this.yaoishota.Text = "Shotacon";
            this.yaoishota.UseVisualStyleBackColor = true;
            // 
            // bara
            // 
            this.bara.AutoSize = true;
            this.bara.Location = new System.Drawing.Point(6, 16);
            this.bara.Name = "bara";
            this.bara.Size = new System.Drawing.Size(86, 17);
            this.bara.TabIndex = 12;
            this.bara.Text = "Bara Doujins";
            this.bara.UseVisualStyleBackColor = true;
            // 
            // savepath
            // 
            this.savepath.Location = new System.Drawing.Point(115, 205);
            this.savepath.Name = "savepath";
            this.savepath.ReadOnly = true;
            this.savepath.Size = new System.Drawing.Size(275, 20);
            this.savepath.TabIndex = 14;
            // 
            // saveb
            // 
            this.saveb.Location = new System.Drawing.Point(34, 203);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(75, 23);
            this.saveb.TabIndex = 13;
            this.saveb.Text = "Save to";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.tagengl);
            this.settings.Controls.Add(this.alltags);
            this.settings.Controls.Add(this.allinengl);
            this.settings.Controls.Add(this.all);
            this.settings.Location = new System.Drawing.Point(154, 27);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(234, 66);
            this.settings.TabIndex = 12;
            this.settings.TabStop = false;
            this.settings.Text = "Site Setting";
            // 
            // tagengl
            // 
            this.tagengl.AutoSize = true;
            this.tagengl.Location = new System.Drawing.Point(80, 39);
            this.tagengl.Name = "tagengl";
            this.tagengl.Size = new System.Drawing.Size(121, 17);
            this.tagengl.TabIndex = 3;
            this.tagengl.TabStop = true;
            this.tagengl.Text = "only Engl. from Tags";
            this.tagengl.UseVisualStyleBackColor = true;
            // 
            // alltags
            // 
            this.alltags.AutoSize = true;
            this.alltags.Location = new System.Drawing.Point(80, 19);
            this.alltags.Name = "alltags";
            this.alltags.Size = new System.Drawing.Size(118, 17);
            this.alltags.TabIndex = 2;
            this.alltags.TabStop = true;
            this.alltags.Text = "evrything from Tags";
            this.alltags.UseVisualStyleBackColor = true;
            // 
            // allinengl
            // 
            this.allinengl.AutoSize = true;
            this.allinengl.Location = new System.Drawing.Point(6, 39);
            this.allinengl.Name = "allinengl";
            this.allinengl.Size = new System.Drawing.Size(62, 17);
            this.allinengl.TabIndex = 1;
            this.allinengl.TabStop = true;
            this.allinengl.Text = "all Engl.";
            this.allinengl.UseVisualStyleBackColor = true;
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Location = new System.Drawing.Point(5, 19);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(75, 17);
            this.all.TabIndex = 0;
            this.all.TabStop = true;
            this.all.Text = "give me all";
            this.all.UseVisualStyleBackColor = true;
            // 
            // tags
            // 
            this.tags.Controls.Add(this.furry);
            this.tags.Controls.Add(this.yaoi);
            this.tags.Controls.Add(this.darkskin);
            this.tags.Controls.Add(this.ffm);
            this.tags.Controls.Add(this.futanari);
            this.tags.Controls.Add(this.crossdressing);
            this.tags.Controls.Add(this.femalesonly);
            this.tags.Controls.Add(this.yuri);
            this.tags.Controls.Add(this.tomboy);
            this.tags.Controls.Add(this.garter);
            this.tags.Controls.Add(this.lolicon);
            this.tags.Controls.Add(this.mature);
            this.tags.Location = new System.Drawing.Point(34, 106);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(356, 91);
            this.tags.TabIndex = 11;
            this.tags.TabStop = false;
            this.tags.Text = "Tags to Load";
            // 
            // furry
            // 
            this.furry.AutoSize = true;
            this.furry.Location = new System.Drawing.Point(264, 62);
            this.furry.Name = "furry";
            this.furry.Size = new System.Drawing.Size(46, 17);
            this.furry.TabIndex = 23;
            this.furry.Text = "furry";
            this.furry.UseVisualStyleBackColor = true;
            // 
            // yaoi
            // 
            this.yaoi.AutoSize = true;
            this.yaoi.Location = new System.Drawing.Point(178, 62);
            this.yaoi.Name = "yaoi";
            this.yaoi.Size = new System.Drawing.Size(45, 17);
            this.yaoi.TabIndex = 22;
            this.yaoi.Text = "yaoi";
            this.yaoi.UseVisualStyleBackColor = true;
            // 
            // darkskin
            // 
            this.darkskin.AutoSize = true;
            this.darkskin.Location = new System.Drawing.Point(92, 62);
            this.darkskin.Name = "darkskin";
            this.darkskin.Size = new System.Drawing.Size(69, 17);
            this.darkskin.TabIndex = 21;
            this.darkskin.Text = "dark skin";
            this.darkskin.UseVisualStyleBackColor = true;
            // 
            // ffm
            // 
            this.ffm.AutoSize = true;
            this.ffm.Location = new System.Drawing.Point(6, 62);
            this.ffm.Name = "ffm";
            this.ffm.Size = new System.Drawing.Size(47, 17);
            this.ffm.TabIndex = 20;
            this.ffm.Text = "FFM";
            this.ffm.UseVisualStyleBackColor = true;
            // 
            // futanari
            // 
            this.futanari.AutoSize = true;
            this.futanari.Location = new System.Drawing.Point(264, 39);
            this.futanari.Name = "futanari";
            this.futanari.Size = new System.Drawing.Size(61, 17);
            this.futanari.TabIndex = 19;
            this.futanari.Text = "futanari";
            this.futanari.UseVisualStyleBackColor = true;
            // 
            // crossdressing
            // 
            this.crossdressing.AutoSize = true;
            this.crossdressing.Location = new System.Drawing.Point(264, 16);
            this.crossdressing.Name = "crossdressing";
            this.crossdressing.Size = new System.Drawing.Size(90, 17);
            this.crossdressing.TabIndex = 18;
            this.crossdressing.Text = "crossdressing";
            this.crossdressing.UseVisualStyleBackColor = true;
            // 
            // femalesonly
            // 
            this.femalesonly.AutoSize = true;
            this.femalesonly.Location = new System.Drawing.Point(178, 39);
            this.femalesonly.Name = "femalesonly";
            this.femalesonly.Size = new System.Drawing.Size(84, 17);
            this.femalesonly.TabIndex = 17;
            this.femalesonly.Text = "females only";
            this.femalesonly.UseVisualStyleBackColor = true;
            // 
            // yuri
            // 
            this.yuri.AutoSize = true;
            this.yuri.Location = new System.Drawing.Point(178, 16);
            this.yuri.Name = "yuri";
            this.yuri.Size = new System.Drawing.Size(42, 17);
            this.yuri.TabIndex = 16;
            this.yuri.Text = "yuri";
            this.yuri.UseVisualStyleBackColor = true;
            // 
            // tomboy
            // 
            this.tomboy.AutoSize = true;
            this.tomboy.Location = new System.Drawing.Point(92, 39);
            this.tomboy.Name = "tomboy";
            this.tomboy.Size = new System.Drawing.Size(60, 17);
            this.tomboy.TabIndex = 15;
            this.tomboy.Text = "tomboy";
            this.tomboy.UseVisualStyleBackColor = true;
            // 
            // garter
            // 
            this.garter.AutoSize = true;
            this.garter.Location = new System.Drawing.Point(92, 16);
            this.garter.Name = "garter";
            this.garter.Size = new System.Drawing.Size(73, 17);
            this.garter.TabIndex = 14;
            this.garter.Text = "garter belt";
            this.garter.UseVisualStyleBackColor = true;
            // 
            // lolicon
            // 
            this.lolicon.AutoSize = true;
            this.lolicon.Location = new System.Drawing.Point(6, 39);
            this.lolicon.Name = "lolicon";
            this.lolicon.Size = new System.Drawing.Size(56, 17);
            this.lolicon.TabIndex = 13;
            this.lolicon.Text = "lolicon";
            this.lolicon.UseVisualStyleBackColor = true;
            // 
            // mature
            // 
            this.mature.AutoSize = true;
            this.mature.Location = new System.Drawing.Point(6, 16);
            this.mature.Name = "mature";
            this.mature.Size = new System.Drawing.Size(59, 17);
            this.mature.TabIndex = 12;
            this.mature.Text = "Mature";
            this.mature.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nhentai);
            this.groupBox3.Controls.Add(this.yaoiheaven);
            this.groupBox3.Location = new System.Drawing.Point(34, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 66);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Site";
            // 
            // nhentai
            // 
            this.nhentai.AutoSize = true;
            this.nhentai.Location = new System.Drawing.Point(10, 19);
            this.nhentai.Name = "nhentai";
            this.nhentai.Size = new System.Drawing.Size(60, 17);
            this.nhentai.TabIndex = 17;
            this.nhentai.TabStop = true;
            this.nhentai.Text = "nhentai";
            this.nhentai.UseVisualStyleBackColor = true;
            this.nhentai.CheckedChanged += new System.EventHandler(this.nhentai_CheckStateChanged);
            // 
            // yaoiheaven
            // 
            this.yaoiheaven.AutoSize = true;
            this.yaoiheaven.Location = new System.Drawing.Point(10, 39);
            this.yaoiheaven.Name = "yaoiheaven";
            this.yaoiheaven.Size = new System.Drawing.Size(80, 17);
            this.yaoiheaven.TabIndex = 18;
            this.yaoiheaven.TabStop = true;
            this.yaoiheaven.Text = "yaoiheaven";
            this.yaoiheaven.UseVisualStyleBackColor = true;
            this.yaoiheaven.CheckedChanged += new System.EventHandler(this.yaoiheaven_CheckStateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Maker});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Maker
            // 
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(57, 20);
            this.Maker.Text = "Version";
            this.Maker.Click += new System.EventHandler(this.Maker_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_WOC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.DarkOrange;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(674, 377);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC1.Size = new System.Drawing.Size(114, 115);
            this.button_WOC1.TabIndex = 13;
            this.button_WOC1.Text = " Copy \r\n   to\r\n Source";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.button_WOC1, "sdgsdg");
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // scan_button
            // 
            this.scan_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scan_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scan_button.BorderColor = System.Drawing.Color.Transparent;
            this.scan_button.ButtonColor = System.Drawing.Color.Green;
            this.scan_button.FlatAppearance.BorderSize = 0;
            this.scan_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scan_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_button.Location = new System.Drawing.Point(668, 125);
            this.scan_button.Name = "scan_button";
            this.scan_button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.scan_button.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.scan_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.scan_button.Size = new System.Drawing.Size(125, 115);
            this.scan_button.TabIndex = 10;
            this.scan_button.Text = "SCAN";
            this.scan_button.TextColor = System.Drawing.Color.Black;
            this.scan_button.UseVisualStyleBackColor = true;
            this.scan_button.Click += new System.EventHandler(this.scan_button_Click);
            // 
            // Sort_Ordner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(818, 565);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sort_Ordner";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordner Vergleichen";
            same_folder.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.compaer_folder.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.crawler.ResumeLayout(false);
            this.crawler.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPage)).EndInit();
            this.yaoitags.ResumeLayout(false);
            this.yaoitags.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.tags.ResumeLayout(false);
            this.tags.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ordner;
        private System.Windows.Forms.TextBox path_box;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button delete_button_find_folder;
        private System.Windows.Forms.Label ordnerfound;
        private System.Windows.Forms.Label dateienfound;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage compaer_folder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox checked_ordner_txt;
        private System.Windows.Forms.TextBox source_folder_text;
        private System.Windows.Forms.Button checking_folder;
        private System.Windows.Forms.Button source_folder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton duplicate_3;
        private System.Windows.Forms.RadioButton duplicate_5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton duplicate_7;
        private System.Windows.Forms.Label Quellen;
        private ePOSOne.btnProduct.Button_WOC scan_button;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ListView listView2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage crawler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.GroupBox tags;
        private System.Windows.Forms.CheckBox furry;
        private System.Windows.Forms.CheckBox yaoi;
        private System.Windows.Forms.CheckBox darkskin;
        private System.Windows.Forms.CheckBox ffm;
        private System.Windows.Forms.CheckBox futanari;
        private System.Windows.Forms.CheckBox crossdressing;
        private System.Windows.Forms.CheckBox femalesonly;
        private System.Windows.Forms.CheckBox yuri;
        private System.Windows.Forms.CheckBox tomboy;
        private System.Windows.Forms.CheckBox garter;
        private System.Windows.Forms.CheckBox lolicon;
        private System.Windows.Forms.CheckBox mature;
        private System.Windows.Forms.GroupBox yaoitags;
        private System.Windows.Forms.CheckBox yaoifurry;
        private System.Windows.Forms.CheckBox yaoicube;
        private System.Windows.Forms.CheckBox yaoianime;
        private System.Windows.Forms.CheckBox yaoiyaoi;
        private System.Windows.Forms.CheckBox yaoishota;
        private System.Windows.Forms.CheckBox bara;
        private System.Windows.Forms.Button dlsitebutton;
        public System.Windows.Forms.RadioButton nhentai;
        public System.Windows.Forms.RadioButton yaoiheaven;
        public System.Windows.Forms.TextBox savepath;
        private System.Windows.Forms.RadioButton tagengl;
        private System.Windows.Forms.RadioButton alltags;
        private System.Windows.Forms.RadioButton allinengl;
        private System.Windows.Forms.RadioButton all;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Maker;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox dlpage;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.ListBox log;
        private System.Windows.Forms.NumericUpDown startPage;
    }
}

