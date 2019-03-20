using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    [JsonObject]
    public class CoinMarketCap
    {
        #region Public properties



        public string id { get; set; }

        public string name { get; set; }

        public string symbol { get; set; }

        public decimal rank { get; set; }

        public decimal price_usd { get; set; }

        public decimal price_btc { get; set; }

        [JsonProperty("24h_volume_usd")]
        public decimal DayVolumeUSD { get; set; }

        public decimal market_cap_usd { get; set; }

        public decimal available_supply { get; set; }

        public decimal total_supply { get; set; }

        public decimal percent_change_1h { get; set; }

        public decimal percent_change_24h { get; set; }

        public decimal percent_change_7d { get; set; }

        public ulong last_updated { get; set; } 

        public decimal price_rub { get; set; }

        [JsonProperty("24h_volume_rub")]
        public decimal DayVolumeRUB { get; set; }

        public decimal market_cap_rub { get; set; }



        #endregion
        #region Public methods



        public static async Task<CoinMarketCap[]> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Properties.Settings.Default.COINMARKETCAPAPIUrl, cancellationToken);

                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<CoinMarketCap[]>(responseString);
            }
        }



        #endregion
    }
}
