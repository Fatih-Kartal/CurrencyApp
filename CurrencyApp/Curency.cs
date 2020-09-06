using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp
{
    public class Currency
    {
        [JsonProperty(PropertyName = "ALIS")]
        public string BuyingPrice { get; set; }

        [JsonProperty(PropertyName = "SATIS")]
        public string SellingPrice { get; set; }

        [JsonProperty(PropertyName = "SEMBOL")]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "ACIKLAMA")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "YUZDEDEGISIM")]
        public string Percent { get; set; }
    }
}
