using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyApp
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadingProgressBar.Value = e.ProgressPercentage;
        }

        private void startUpdateButton_Click(object sender, EventArgs e)
        {
            StartUpdate();
        }

        private void StartUpdate()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;

                var url = new System.Uri("https://raw.githubusercontent.com/Fatih-Kartal/CurrencyApp/master/CurrencyApp/bin/Debug/CurrencyApp.exe");
                string targetlocation = "Update\\CurrencyApp.exe";
                webClient.DownloadFileTaskAsync(url, targetlocation);
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
