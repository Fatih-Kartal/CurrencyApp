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
        public USD USD { get; set; }

        [JsonProperty(PropertyName = "EURO")]
        public EUR EUR { get; set; }

        [JsonProperty(PropertyName = "İNGİLİZ STERLİNİ")]
        public GBP GBP { get; set; }

        [JsonProperty(PropertyName = "Gram Altın")]
        public Gold Gold { get; set; }
    }
}
