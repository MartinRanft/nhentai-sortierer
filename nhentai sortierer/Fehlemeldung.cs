using System;
using System.Windows.Forms;

namespace WoH_Site_Downloader
{
    public partial class Fehlemeldung : Form
    {
        public Fehlemeldung(Boolean OrdnerEmpty, Boolean FehlerOrdnerNotFound)
        {
            InitializeComponent();
            if (OrdnerEmpty == true)
            {
                string code = "Bitte ein Verzeichnisswählen";
                this.label1.Text = code;
            }
            else if (OrdnerEmpty == false && FehlerOrdnerNotFound == true)
            {
                string code = "Ordner wurde nicht gefunden";
                this.label1.Text = code;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}