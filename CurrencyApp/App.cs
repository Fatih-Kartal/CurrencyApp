using System;
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

        public Currencies GetCurrencies()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://finans.truncgil.com/today.json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return JsonConvert.DeserializeObject<Currencies>(content);
        }
        public void LoadCurrencies()
        {
            Currencies currencies = GetCurrencies();
            USDBuyingPriceLabel.Text = currencies.USD.BuyingPrice.Substring(0, 6);
            USDSellingPriceLabel.Text = currencies.USD.SellingPrice.Substring(0, 6);

            EURBuyingPriceLabel.Text = currencies.EUR.BuyingPrice.Substring(0, 6);
            EURSellingPriceLabel.Text = currencies.EUR.SellingPrice.Substring(0, 6);

            GBPBuyingPriceLabel.Text = currencies.GBP.BuyingPrice.Substring(0, 6);
            GBPSellingPriceLabel.Text = currencies.GBP.SellingPrice.Substring(0, 6);

            GoldBuyingPriceLabel.Text = currencies.Gold.BuyingPrice.Substring(0, 6);
            GoldSellingPriceLabel.Text = currencies.Gold.SellingPrice.Substring(0, 6);
        }
    }
}
