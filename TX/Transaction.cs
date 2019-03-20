using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.TX
{
    /*
     * https://blockchain.info/rawtx/7849076235c6c85665f66e04f368d41d5867f63edd83cc08dbf926efb7fd9314
     * 
     {
   "ver":1,
   "inputs":[
      {
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
   ],
   "block_height":468496,
   "relayed_by":"127.0.0.1",
   "out":[
      {
         "spent":false,
         "tx_index":254958997,
         "type":0,
         "addr":"1KkBpxe22tEXpVN8RBaGfSwQJcyzaKoJZV",
         "value":100000,
         "n":0,
         "script":"76a914cd9d3033f2d338fad9e7c100ddd4a92299a3259688ac"
      },
      {
         "spent":false,
         "tx_index":254958997,
         "type":0,
         "addr":"13BefxBigVaAjM6GnaHEJe6rqRwTnquLLg",
         "value":1865760,
         "n":1,
         "script":"76a91417f3db9b062a8cab29d304be5ab4ce342cab99e588ac"
      }
   ],
   "lock_time":0,
   "size":226,
   "double_spend":false,
   "time":1495817899,
   "tx_index":254958997,
   "vin_sz":1,
   "hash":"7849076235c6c85665f66e04f368d41d5867f63edd83cc08dbf926efb7fd9314",
   "vout_sz":2
}
     */
    /// <summary>
    /// Транзакция BTC
    /// </summary>
    [JsonObject]
    public class Transaction
    {
        #region Public properties



        /// <summary>
        /// Версия 
        /// </summary>
        [JsonProperty("ver")]
        public int Version { get; set; }

        /// <summary>
        /// Входящие переводы
        /// </summary>
        [JsonProperty("inputs")]
        public InputData[] Inputs { get; set; }

        /// <summary>
        /// Высота блока (по сути номер)
        /// </summary>
        [JsonProperty("block_height")]
        public long BlockHeight { get; set; }

        /// <summary>
        /// Передано через (обычно IP)
        /// </summary>
        [JsonProperty("relayed_by")]
        public string RelayedBy { get; set; }

        /// <summary>
        /// Получатели переводов
        /// </summary>
        [JsonProperty("out")]
        public Transfer[] Outputs { get; set; }

        /// <summary>
        /// Время
        /// </summary>
        [JsonProperty("lock_time")]
        public int LockTime { get; set; }

        /// <summary>
        /// Размер
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Двойное проведение
        /// </summary>
        [JsonProperty("double_spend")]
        public bool DoubleSpend { get; set; }

        /// <summary>
        /// Время
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Индекс транзакции
        /// </summary>
        [JsonProperty("tx_index")]
        public long Index { get; set; }

        /// <summary>
        /// Количество входящих сумм (размер массива Inputs)
        /// </summary>
        [JsonProperty("vin_sz")]
        public int InputSize { get; set; }

        /// <summary>
        /// Хеш транзакции
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Размер выходного массива выводов (Outputs)
        /// </summary>
        [JsonProperty("vout_sz")]
        public int OutputSize { get; set; }

        
        
        #endregion
        #region Public constructors



        public Transaction()
        {

        }



        #endregion
        #region Public methods



        /// <summary>
        /// Загружает транзакцию из веба
        /// </summary>
        /// <param name="txid">Номер транзакции в сети Червонца</param>
        /// <param name="cancellationToken">Токен отмены операции</param>
        /// <returns></returns>
        public static async Task<Transaction> LoadFromWebAsync(string txid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            string sUrl = Properties.Settings.Default.BTCTRXUrl + txid;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(sUrl, cancellationToken);

                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Transaction>(responseString);
            }
        }



        #endregion
    }
}
