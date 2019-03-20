using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    [JsonObject]
    public class BittrexRate
    {
        #region Public properties



        [JsonProperty("Bid")]
        public decimal Buy { get; set; }

        [JsonProperty("Ask")]
        public decimal Sell { get; set; }

        [JsonProperty("Last")]
        public decimal Last { get; set; }



        #endregion
    }
}
