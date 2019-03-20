using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.TX
{
    /*
       {
         "spent":false,
         "tx_index":254958997,
         "type":0,
         "addr":"13BefxBigVaAjM6GnaHEJe6rqRwTnquLLg",
         "value":1865760,
         "n":1,
         "script":"76a91417f3db9b062a8cab29d304be5ab4ce342cab99e588ac"
      }
    */
    /// <summary>
    /// Описывает перевод (движение средств как из кошелька так и в кошелек, по сути половинка операции)
    /// </summary>
    [JsonObject]
    public class Transfer
    {
        #region Public properties



        /// <summary>
        /// Потрачен (флаг использования в дальнейшем переводе)
        /// </summary>
        [JsonProperty("spent")]
        public bool Spent { get; set; }

        /// <summary>
        /// Номер перевода
        /// </summary>
        [JsonProperty("tx_index")]
        public long Index { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        [JsonProperty("addr")]
        public string Address { get; set; }

        /// <summary>
        /// Сумма перевода в переводе на единицы 100000 === 0.001 (надо поделить на 100 000 000 для конверта в единицы)
        /// </summary>
        [JsonProperty("value")]
        public ulong Value { get; set; }

        /// <summary>
        /// Последовательность (для сортировки)
        /// </summary>
        [JsonProperty("n")]
        public int OrderN { get; set; }

        /// <summary>
        /// Подпись перевода
        /// </summary>
        [JsonProperty("script")]
        public string Script { get; set; }



        #endregion
    }
}
