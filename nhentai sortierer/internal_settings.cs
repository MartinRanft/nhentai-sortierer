using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace WoH_Site_Downloader
{
    public class internal_settings
    {
        public static string ToolTipTextCopy = "Kopiert ALLE dateien vom Pruefenden Ordner in den Source Ordner";

        public static void listviewSettings(ListView list)
        {
            list.CheckBoxes = true;
            list.AllowColumnReorder = true;
            list.GridLines = true;
            list.Sorting = SortOrder.Ascending;
            list.AllowColumnReorder = true;
            list.FullRowSelect = false;
            list.Columns.Clear();
            list.Columns.Add("Ordnername", -2);
            list.Columns.Add("Dateien im Ordner", -2);
            list.Columns.Add("Pfad des Ordners", -2);
        }

        public static Boolean AskToDelete(ListView list)
        {
            string MessageBoxText = "Achtung wollen Sie die Ordner wirklich löschen?";
            string caption = "Delete Ordner ?";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage image = MessageBoxImage.Warning;

            MessageBoxResult result = System.Windows.MessageBox.Show(MessageBoxText, caption, button, image);

            if (result == MessageBoxResult.Yes)
            {
                for (int zahl = 0; zahl < list.CheckedItems.Count; zahl++)
                {
                    String ausgabe = list.CheckedItems[zahl].SubItems[2].Text;
                    Directory.Delete(ausgabe.ToString(), true);
                }
                return true;
            }
            return false;
        }

        public static Boolean BenutzerFrage(string headline, string message, MessageBoxButton button, MessageBoxImage image)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show(message, headline, button, image);

            if (result == MessageBoxResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Maker()
        {
            string MessageBoxText = "Created by Fallout from WoH Board";
            string caption = "visite https://board.world-of-hentai.to";
            string newline = "For more feature ask in the board";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage image = MessageBoxImage.Information;

            MessageBoxResult result = System.Windows.MessageBox.Show(MessageBoxText + Environment.NewLine + newline + Environment.NewLine + " Version: " + System.Windows.Forms.Application.ProductVersion, caption, button, image);
        }
    }
}