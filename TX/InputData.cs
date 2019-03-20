using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.TX
{
    /*
     *       {
         "sequence":4294967295,
         "prev_out":{
            "spent":true,
            "tx_index":253076728,
            "type":0,
            "addr":"1PF5gdQqRpaJggG4p3UsxZG2MDWbQCrWr",
            "value":2020000,
            "n":0,
            "script":"76a9140434e7b977a69297591999068588b54f95fe601788ac"
         },
         "script":"483045022100a8e18a2d1b9cb5169ef127fa66956ab1f7925300b0d421c41ca94e6f990f9d4402203a41997483968eb9869679d45fe07f9c77e1c89c73907d5f3642ffadad4210e8012103a5f07542066e6608c105e47f54a5b6a0bea546e72c45e3452afd4a9f2d2b0d97"
      }

     */
    /// <summary>
    /// Входящие данные по транзакции
    /// </summary>
    [JsonObject]
    public class InputData
    {
        #region Public properties



        /// <summary>
        /// Номер в последовательности
        /// </summary>
        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        /// <summary>
        /// Перевод входа
        /// </summary>
        [JsonProperty("prev_out")]
        public Transfer PrevOutput { get; set; }

        /// <summary>
        /// Подпись
        /// </summary>
        [JsonProperty("script")]
        public string Script { get; set; }



        #endregion
    }
}
