using System;
using System.Windows.Forms;

namespace WoH_Site_Downloader
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void updateProgressBar(int percent)
        {
            this.progressBar1.Value = percent;
        }
    }
}