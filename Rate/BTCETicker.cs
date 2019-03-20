using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    [JsonObject]
    public class BTCETicker
    {
        #region Public properties



        [JsonProperty("high")]
        public decimal Hight;

        [JsonProperty("low")]
        public decimal Low;

        [JsonProperty("avg")]
        public decimal Average;

        [JsonProperty("vol")]
        public decimal Volume;

        [JsonProperty("vol_cur")]
        public decimal CurrentVolume;

        [JsonProperty("last")]
        public decimal Last;

        [JsonProperty("buy")]
        public decimal Buy;

        [JsonProperty("sell")]
        public decimal Sell;

        [JsonProperty("updated")]
        public ulong UnixTime;



        #endregion
    }
}
