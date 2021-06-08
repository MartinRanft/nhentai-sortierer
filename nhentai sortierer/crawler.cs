using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows;

namespace WoH_Site_Downloader
{
    public class crawler
    {
        public const int PAGENHENTAI = 1;
        public const int PAGEYAOIHAVEN = 2;

        private string nhentai = "https://nhentai.net";
        private string yaoiheaven = "https://www.yaoihavenreborn.com";
        private bool engl;

        private Sort_Ordner gui = null;
        private int pageId = 0;
        private string savePath = "";
        private int startPage = 0;
        private int dlpage = 0;
        private bool yaoitag = false;
        private Dictionary<string, bool> chooselang;
        private Dictionary<string, bool> nhentaitagliste;
        private Dictionary<string, bool> yaoitagliste;

        public crawler(Sort_Ordner Getgui, int GetpageId, string GetsavePath, int GetstartPage, int Getdlpage, Dictionary<string, bool> Getchooselang, Dictionary<string, bool> Getnhentaitagliste, Dictionary<string, bool> Getyaoitagliste)
        {
            this.gui = Getgui;
            this.pageId = GetpageId;
            this.savePath = GetsavePath;
            this.startPage = GetstartPage;
            this.dlpage = Getdlpage;
            this.chooselang = Getchooselang;
            this.nhentaitagliste = Getnhentaitagliste;
            this.yaoitagliste = Getyaoitagliste;
        }

        /// <summary>
        /// hier wird die site aufgerufen
        /// </summary>

        public void Loader()
        {
            string url = "";

            switch (this.pageId)
            {
                case crawler.PAGENHENTAI:
                    foreach (var lang in this.chooselang)
                    {
                        switch (lang.Key.ToString())
                        {
                            case "all":
                                if (lang.Value)
                                {
                                    url = nhentai + "/";
                                    engl = false;
                                    this.Sitecrawler(url);
                                    break;
                                }
                                break;

                            case "allinengl":
                                if (lang.Value)
                                {
                                    url = nhentai + "/language/english/";
                                    engl = false;
                                    this.Sitecrawler(url); ;
                                    break;
                                }
                                break;

                            case "alltags":
                                if (lang.Value)
                                {
                                    bool foundValue = false;
                                    foreach (var tag in nhentaitagliste)
                                    {
                                        if (tag.Value)
                                        {
                                            foundValue = true;
                                            url = nhentai + "/tag/" + tag.Key.ToString() + "/";
                                            engl = false;
                                            this.Sitecrawler(url);
                                        }
                                    }
                                    if (foundValue == false)
                                    {
                                        string message = "Please select a Tag";
                                        _ = internal_settings.BenutzerFrage("Select Tag", message, MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                    break;
                                }
                                break;

                            case "tagengl":
                                if (lang.Value)
                                {
                                    bool foundValue = false;
                                    foreach (var tag in nhentaitagliste)
                                    {
                                        if (tag.Value)
                                        {
                                            foundValue = true;
                                            url = nhentai + "/tag/" + tag.Key.ToString() + "/";
                                            engl = true;
                                            this.Sitecrawler(url);
                                        }
                                    }
                                    if (foundValue == false)
                                    {
                                        internal_settings.BenutzerFrage("Select Tag", "Please select a Tag", MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                    break;
                                }
                                break;
                        }
                    }
                    break;

                case crawler.PAGEYAOIHAVEN:
                    foreach (var lang in this.chooselang)
                    {
                        switch (lang.Key.ToString())
                        {
                            case "all":
                                if (lang.Value)
                                {
                                    url = yaoiheaven + "/doujinshi/all-doujinshi/";
                                    engl = false;
                                    this.Sitecrawler(url);
                                    break;
                                }
                                break;

                            case "allinengl":
                                if (lang.Value)
                                {
                                    url = yaoiheaven + "/doujinshi/all-doujinshi/";
                                    engl = true;
                                    this.Sitecrawler(url);
                                    break;
                                }
                                break;

                            case "alltags":
                                if (lang.Value)
                                {
                                    foreach (var tag in yaoitagliste)
                                    {
                                        if (tag.Value)
                                        {
                                            engl = false;
                                            yaoitag = true;
                                            this.Sitecrawler(tag.Key.ToString());
                                        }
                                    }
                                    break;
                                }
                                break;

                            case "tagengl":
                                if (lang.Value)
                                {
                                    foreach (var tag in yaoitagliste)
                                    {
                                        if (tag.Value)
                                        {
                                            engl = true;
                                            yaoitag = true;
                                            this.Sitecrawler(tag.Key.ToString());
                                        }
                                    }
                                    break;
                                }
                                break;
                        }
                    }
                    break;

                default:
                    string MessageBox = "Please Select a site";
                    string caption = "";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage image = MessageBoxImage.Error;
                    MessageBoxResult result = System.Windows.MessageBox.Show(MessageBox, caption, button, image);
                    break;
            }
        }

        /// <summary>
        /// Hier wird eine Http verbindung aufgebaut sowie der html inhalt in einen String gespeichert
        /// </summary>

        private string getHtmlString(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                WebRequest webRequest = (WebRequest)httpWebRequest;
                webRequest.Proxy = null;
                WebResponse webResponse = webRequest.GetResponse();
                StreamReader sr = new StreamReader(webResponse.GetResponseStream());
                url = sr.ReadToEnd();
                System.Threading.Thread.Sleep(200);
                return url;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Erstellt den Ordner an der angegebenen stelle und Erstellt die Image dateien die er vom Webserver bekommt
        /// </summary>

        private bool getImage(string url, string filename, string ordnername)
        {
            try
            {
                //return false;
                char[] replace = { '<', '>', '|', '?', '*', '\\', '/', '\"', ':' };

                int stringlength = ordnername.Length;
                ordnername = ordnername.Substring(21, (stringlength - 9));
                int gesamtlänge = this.savePath.Length + ordnername.Length;

                if (gesamtlänge > 247)
                {
                    if (ordnername.Length > 180)
                    {
                        ordnername = ordnername.Substring(0, 180);
                        gesamtlänge = this.savePath.Length + ordnername.Length;
                        if (gesamtlänge > 247)
                        {
                            string MessageBoxText = "The Max path length from Windows has been reached! PLease select another Folder";
                            string caption = "";
                            MessageBoxButton button = MessageBoxButton.OK;
                            MessageBoxImage image = MessageBoxImage.Warning;

                            MessageBoxResult result = MessageBox.Show(MessageBoxText, caption, button, image);
                            if (result == MessageBoxResult.OK)
                            {
                                return true;
                            }
                        }
                    }
                }

                foreach (char cha in replace)
                {
                    ordnername = ordnername.Replace(cha, ' ');
                }

                string Spath = this.savePath + "\\" + ordnername;

                if (!Directory.Exists(Spath))
                {
                    Directory.CreateDirectory(Spath);
                }
                Spath = Spath + "\\" + filename;
                Console.WriteLine(Spath);
                if (!File.Exists(Spath))
                {
                    HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    WebRequest webRequest = (WebRequest)httpWebRequest;
                    webRequest.Proxy = null;
                    WebResponse webResponse = webRequest.GetResponse();
                    Image img = Image.FromStream(webResponse.GetResponseStream());
                    img.Save(Spath);
                    img.Dispose();
                    System.Threading.Thread.Sleep(200);
                    return false;
                }
                return false;
            }
            catch (WebException ex)
            {
                this.gui.writeToConsole(ex.ToString());
                return true;
            }
        }

        /// <summary>
        /// Der eigentliche Site crawler dieser prüft welche site benutzt werden soll und benutzt die entsprechende Logik //todo:Logik bauen
        /// </summary>

        private void Sitecrawler(string url)
        {
            string dojiname = "";
            int pageNumber = this.startPage;
            int downloadPages = this.dlpage;
            bool stop = false;

            if (this.pageId == PAGENHENTAI)
            {
                while (stop == false)
                {
                    string newurl = url + "?page=" + pageNumber;

                    string htmlString = this.getHtmlString(newurl);
                    MatchCollection main = Regex.Matches(htmlString, "/g/[^\"]*/");
                    if (main.Count == 0 || pageNumber > downloadPages)
                    {
                        stop = true;
                        break;
                    }

                    pageNumber++;
                    string datatyp = "";

                    foreach (var data in main)
                    {
                        string newUrl = nhentai + data.ToString();
                        string gal = this.getHtmlString(newUrl);
                        MatchCollection gallerie = Regex.Matches(gal, data + "[^\"]*/");
                        MatchCollection galname = Regex.Matches(gal, "<div class=\"caption\">[^\"]*</div>");

                        if (engl == true)
                        {
                            MatchCollection isEngl = Regex.Matches(gal, "[^\"]* tag-12227 [^\"]*");
                            Console.WriteLine(isEngl.Count);
                            if (isEngl.Count == 0)
                            {
                                continue;
                            }
                        }

                        int stringlength = galname[0].Length;
                        if (galname[0].Value.Substring(4, (stringlength - 9)) != dojiname)
                        {
                            this.gui.writeToConsole("Loaded/Loading");
                            this.gui.writeToConsole(galname[0].Value.Substring(4, (stringlength - 9)));
                            dojiname = galname[0].Value;
                        }

                        for (int i = 1; i < gallerie.Count; i++)
                        {
                            string imagegal = newUrl + i + "/";
                            string image = this.getHtmlString(imagegal);
                            string[] Imagetype = { "jpg", "png", "gif" };

                            foreach (string type in Imagetype)
                            {
                                int result = Regex.Matches(image, "[^\"]*." + type).Count;
                                if (result > 0)
                                {
                                    datatyp = type;
                                    break;
                                }
                            }
                            MatchCollection lastpage = Regex.Matches(image, "https://i.nhentai.net/galleries/" + "[^\"]*/[^\"]*." + datatyp);
                            stop = this.getImage(lastpage[0].Value, i + "." + datatyp, galname[0].Value);
                            if (stop == true)
                            {
                                break;
                            }
                        }
                        if (stop == true)
                        {
                            this.gui.writeToConsole("Download Complete");
                            break;
                        }
                        if (Sort_Ordner.stopCrawlThread == true)
                        {
                            break;
                        }
                    }

                    if (Sort_Ordner.stopCrawlThread == true)
                    {
                        break;
                    }
                }
            }
            else if (this.pageId == PAGEYAOIHAVEN)
            {
                while (stop == false)
                {
                    if (yaoitag)
                    {
                        string newurl = yaoiheaven + url;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        if (pageNumber == 3)
                        {
                            break;
                        }
                        else
                        {
                            pageNumber++;
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string dojinname = getHtmlString(newurl);
                        MatchCollection getGal = Regex.Matches(dojinname, "<h5>[^\"]*</h5>");

                        foreach (var gal in dojinname)
                        {
                            MatchCollection StringAna = Regex.Matches(dojinname, "<a href=\"/doujinshi/[^\"]*\">");
                            for (int i = 0; i < StringAna.Count; i++)
                            {
                                string galTag = StringAna[i].Value.Substring(9, (StringAna[i].Value.Length - 11));

                                if (galTag == "/doujinshi/all-doujinshi")
                                {
                                    continue;
                                    // Hier wird abgebrochen falls einei verlinkung auf all geht
                                }
                                Console.WriteLine(galTag);
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
}