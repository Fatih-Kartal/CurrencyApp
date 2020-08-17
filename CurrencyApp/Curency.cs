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
        [JsonProperty(PropertyName = "Alış")]
        public string BuyingPrice { get; set; }

        [JsonProperty(PropertyName = "Satış")]
        public string SellingPrice { get; set; }

        [JsonProperty(PropertyName = "Tür")]
        public string Type { get; set; }
    }
}
