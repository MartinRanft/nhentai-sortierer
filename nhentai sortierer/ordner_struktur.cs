using System;
using System.Collections.Generic;
using System.IO;

namespace WoH_Site_Downloader
{
    public class GetOrdnerStruktur
    {
        public Dictionary<string, Ordner> Liste1 { get; internal set; }
        public Dictionary<string, Ordner> Liste2 { get; internal set; }

        private string path = "";

        private int totalFolderCount = 0;

        public static int Anzahl(string path)
        {
            int erg = new DirectoryInfo(path).GetFiles().Length;
            return erg;
        }

        public GetOrdnerStruktur(string _path)
        {
            this.path = _path;
            this.Liste1 = new Dictionary<string, Ordner>();
            this.Liste2 = new Dictionary<string, Ordner>();

            this.totalFolderCount = new DirectoryInfo(path).GetFiles().Length;
        }

        public int GetTotalOrderCount()
        {
            int erg = new DirectoryInfo(this.path).GetDirectories().Length;
            return erg;
        }

        public void FillListOrdner(int ListeNumer)
        {
            if (this.path.Length == 0)
            {
                Boolean KeinOrdnerAngegeben = true;
                Boolean einlesen = false;
                new Fehlemeldung(KeinOrdnerAngegeben, einlesen).Show();
            }
            else
            {
                var ordner = new DirectoryInfo(this.path).GetDirectories();

                if (ListeNumer == 1)
                {
                    foreach (var ListOrdner1 in ordner)
                    {
                        Ordner Ordnerliste = new Ordner();
                        Ordnerliste.OrdnerName = ListOrdner1.ToString();
                        Ordnerliste.OrdnerPath = this.path + "\\" + ListOrdner1.ToString();
                        Ordnerliste.DateienAnzahl = Anzahl(Ordnerliste.OrdnerPath);
                        Liste1.Add(ListOrdner1.ToString(), Ordnerliste);
                    }
                }
                else if (ListeNumer == 2)
                {
                    foreach (var ListOrdner2 in ordner)
                    {
                        Ordner Ordnerliste = new Ordner();
                        Ordnerliste.OrdnerName = ListOrdner2.ToString();
                        Ordnerliste.OrdnerPath = this.path + "\\" + ListOrdner2.ToString();
                        Ordnerliste.DateienAnzahl = Anzahl(Ordnerliste.OrdnerPath);
                        Liste2.Add(ListOrdner2.ToString(), Ordnerliste);
                    }
                }
            }
        }

        public int GetWorkedOrdnercount()
        {
            int result = Liste1.Count;
            return result;
        }

        private object DirectoryInfo(string path)
        {
            throw new NotImplementedException("Ordner not Found");
        }

        public static void CopyFolder(string compare, string source)
        {
            var diSource = new DirectoryInfo(source);
            var diTarget = new DirectoryInfo(compare);

            CopyAll(diTarget, diSource);
        }

        private static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}