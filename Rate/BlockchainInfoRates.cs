using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    public class BlockchainInfoRates
    {
        #region Public properties



        public CurrencyRate USD { get; set; }

        public CurrencyRate ISK { get; set; }

        public CurrencyRate HKD { get; set; }

        public CurrencyRate TWD { get; set; }

        public CurrencyRate CHF { get; set; }

        public CurrencyRate EUR { get; set; }

        public CurrencyRate DKK { get; set; }

        public CurrencyRate CLP { get; set; }

        public CurrencyRate CAD { get; set; }

        public CurrencyRate INR { get; set; }

        public CurrencyRate CNY { get; set; }

        public CurrencyRate THB { get; set; }

        public CurrencyRate AUD { get; set; }

        public CurrencyRate SGD { get; set; }

        public CurrencyRate KRW { get; set; }

        public CurrencyRate JPY { get; set; }

        public CurrencyRate PLN { get; set; }

        public CurrencyRate GBP { get; set; }

        public CurrencyRate SEK { get; set; }

        public CurrencyRate NZD { get; set; }

        public CurrencyRate BRL { get; set; }

        public CurrencyRate RUB { get; set; }



        #endregion
        #region Public methods



        public static async Task<BlockchainInfoRates> BlockchainInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Properties.Settings.Default.BlockchainInfoTickerURL, cancellationToken);

                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<BlockchainInfoRates>(responseString);
            }
        }



        #endregion
    }
}
