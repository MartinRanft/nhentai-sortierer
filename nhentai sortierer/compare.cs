using System.Collections.Generic;
using System.Threading;

namespace WoH_Site_Downloader
{
    internal class compare
    {
        public Dictionary<string, Ordner> compareList { get; private set; }

        public compare()
        {
            this.compareList = new Dictionary<string, Ordner>();
        }

        public void compare_ordner(string source_ordner, string compare_folder, int trim)
        {
            GetOrdnerStruktur listbox = new GetOrdnerStruktur(source_ordner);
            Thread threadList1 = new Thread(new ThreadStart(delegate () { listbox.FillListOrdner(1); }));
            threadList1.Start();

            GetOrdnerStruktur listbox2 = new GetOrdnerStruktur(compare_folder);
            Thread threadList2 = new Thread(new ThreadStart(delegate () { listbox2.FillListOrdner(2); }));
            threadList2.Start();

            while (threadList1.IsAlive && threadList2.IsAlive)
            {
                Thread.Sleep(1000);
            }

            foreach (var vergleich in listbox.Liste1.Keys)
            {
                string Name1 = vergleich.Substring(0, trim);
                foreach (var vergleich2 in listbox2.Liste2.Keys)
                {
                    if (Name1 == vergleich2.Substring(0, trim) && vergleich.ToString() == vergleich2.ToString())
                    {
                        Ordner Ordnerliste2 = new Ordner();
                        Ordnerliste2.OrdnerName = vergleich.ToString();
                        Ordnerliste2.OrdnerPath = compare_folder + "\\" + vergleich.ToString();
                        Ordnerliste2.DateienAnzahl = GetOrdnerStruktur.Anzahl(Ordnerliste2.OrdnerPath);
                        compareList.Add(vergleich.ToString(), Ordnerliste2);
                        break;
                    }
                }
            }
        }
    }
}