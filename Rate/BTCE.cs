using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    [JsonObject]
    public class BTCE
    {
        #region Public properties



        [JsonProperty("success")]
        public int? Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("btc_rur")]
        public BTCETicker RUR { get; set; }

        [JsonProperty("btc_usd")]
        public BTCETicker USD { get; set; }

        [JsonProperty("btc_eur")]
        public BTCETicker EUR { get; set; }



        #endregion
        #region Public methods



        public static async Task<BTCE> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Properties.Settings.Default.BTCEAPIUrl, cancellationToken);

                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<BTCE>(responseString);
            }
        }



        #endregion
    }
}
