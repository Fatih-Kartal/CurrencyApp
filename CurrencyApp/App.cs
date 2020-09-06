using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CurrencyApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        private void App_Load(object sender, EventArgs e)
        {
            Rectangle wa = Screen.GetWorkingArea(this);
            this.Location = new Point(wa.Right - Size.Width, wa.Bottom - Size.Height);
            LoadCurrencies();
            timer1.Start();
        }
        private void pinToTopButton_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            pinToTopButton.Text = this.TopMost ? "Unpin" : "Pin";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public List<Currency> GetCurrencies()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://api.bigpara.hurriyet.com.tr/doviz/headerlist/anasayfa");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return JsonConvert.DeserializeObject<Data>(content).Currencies;
        }
        public void LoadCurrencies()
        {
            List<Currency> currencies = GetCurrencies();
            USDBuyingPriceLabel.Text = (currencies[6].BuyingPrice + "000").Substring(0, 6);
            USDSellingPriceLabel.Text = (currencies[6].SellingPrice + "000").Substring(0, 6);

            EURBuyingPriceLabel.Text = (currencies[3].BuyingPrice + "000").Substring(0, 6);
            EURSellingPriceLabel.Text = (currencies[3].SellingPrice + "000").Substring(0, 6);

            GBPBuyingPriceLabel.Text = (currencies[7].BuyingPrice + "000").Substring(0, 6);
            GBPSellingPriceLabel.Text = (currencies[7].SellingPrice + "000").Substring(0, 6);

            GoldBuyingPriceLabel.Text = (currencies[5].BuyingPrice + "000").Substring(0, 6);
            GoldSellingPriceLabel.Text = (currencies[5].SellingPrice + "000").Substring(0, 6);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadCurrencies();
        }
    }
}
