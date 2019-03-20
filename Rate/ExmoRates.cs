using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    /*{"BTC_USD":{"buy_price":"2481.48","sell_price":"2505.652075","last_trade":"2493.16145981","high":"2675.23789","low":"2422","avg":"2543.2618292","vol":"256.76744043","vol_curr":"654275.47460239","updated":1501097573},
     * "BTC_EUR":{"buy_price":"2112.06767593","sell_price":"2130.90684","last_trade":"2112.06767593","high":"2270","low":"2002","avg":"2180.46277901","vol":"25.4598861","vol_curr":"55653.42178454","updated":1501097567},
     * "BTC_RUB":{"buy_price":"150001.76011","sell_price":"150835.4329","last_trade":"150835.4329","high":"158500","low":"147622.94137","avg":"154048.86545049","vol":"101.87583848","vol_curr":"15676593.08873092","updated":1501097571},"*/
    [JsonObject]
    public class ExmoRates
    {
        #region Public properties



        public ExmoRate BTC_USD { get; set; }

        public ExmoRate BTC_EUR { get; set; }

        public ExmoRate BTC_RUB { get; set; }



        #endregion
        #region Public methods



        public static async Task<ExmoRates> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Properties.Settings.Default.EXMOAPIURL, cancellationToken);

                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ExmoRates>(responseString);
            }
        }



        #endregion
    }
}
