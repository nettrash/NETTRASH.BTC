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
    public class BittrexRates
    {
        #region Public properties



        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public BittrexRate Rate { get; set; }



        #endregion
        #region Public methods



        public static async Task<BittrexRates> Get(string sFrom, string sTo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{Properties.Settings.Default.BittrexRateUrl}{sFrom}-{sTo}", cancellationToken);

                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<BittrexRates>(responseString);
            }
        }



        #endregion
    }
}
