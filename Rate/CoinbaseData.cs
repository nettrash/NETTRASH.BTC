using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    [JsonObject]
    public class CoinbaseData
    {
        #region Public properties



        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, decimal> Rates { get; set; }



        #endregion
    }
}
