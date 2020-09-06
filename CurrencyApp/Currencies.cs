using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp
{
    public class Currencies
    {

        [JsonProperty(PropertyName = "ABD DOLARI")]
        public Currency USD { get; set; }

        [JsonProperty(PropertyName = "EURO")]
        public Currency EUR { get; set; }

        [JsonProperty(PropertyName = "İNGİLİZ STERLİNİ")]
        public Currency GBP { get; set; }

        [JsonProperty(PropertyName = "Gram Altın")]
        public Currency Gold { get; set; }
    }

    public class Data
    {
        [JsonProperty(PropertyName = "data")]
        public List<Currency> Currencies { get; set; }
    }
}
