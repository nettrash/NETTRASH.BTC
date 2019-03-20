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
    public class Coinbase
    {
        #region Public properties



        [JsonProperty("data")]
        public CoinbaseData Data { get; set; }



        #endregion
        #region Public methods



        public static async Task<Coinbase> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Properties.Settings.Default.CoinbaseUrl, cancellationToken);

                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Coinbase>(responseString);
            }
        }



        #endregion
    }
}
