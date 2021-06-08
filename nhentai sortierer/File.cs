using System;
using System.IO;

namespace WoH_Site_Downloader
{
    public class FileHandler
    {
        public static bool Read()
        {
            try
            {
                StreamReader sr = new StreamReader("System.woh");
                sr.Read();
                Console.WriteLine(sr.CurrentEncoding);
                sr.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static void erstelleDatei()
        {
            string test = "es geht";

            string enbuff = test;
            StreamWriter writer = new StreamWriter("System.woh");

            writer.Write(enbuff);
            writer.Close();
        }
    }
}