using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    [JsonObject]
    public class CurrencyRate
    {
        #region Public properties



        /// <summary>
        /// Актуально 15 минут
        /// </summary>
        [JsonProperty("15m")]
        public decimal M15 { get; set; }

        /// <summary>
        /// Последнее значение
        /// </summary>
        [JsonProperty("last")]
        public decimal Last { get; set; }

        /// <summary>
        /// Покупка
        /// </summary>
        [JsonProperty("buy")]
        public decimal Buy { get; set; }

        /// <summary>
        /// Продажа
        /// </summary>
        [JsonProperty("sell")]
        public decimal Sell { get; set; }

        /// <summary>
        /// Символ
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }



        #endregion
    }
}
