using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    /// <summary>
    /// {
    ///"account" : "Ivan_Petrov",
    ///"address" : "SXdjZK1beuGYKYDD8utymUmjZkdsHVTazW",
    ///"category" : "receive",
    ///"amount" : 100.00000000,
    ///"vout" : 1,
    ///"confirmations" : 7019,
    ///"bcconfirmations" : 7019,
    ///"blockhash" : "00000000178e2403c42dbd979376027dba6eefc773a2317ed18084b6d2bffa52",
    ///"blockindex" : 1,
    ///"blocktime" : 1457219932,
    ///"txid" : "f35e9c06b80c18ef9263a772dfe25888c0efc49c2c68197060cefc812ce99eae",
    ///"walletconflicts" : [
    ///],
    ///"time" : 1457219926,
    ///"timereceived" : 1457219926
    ///},
    /// </summary>
    [JsonObject]
    public class Transaction
    {
        #region Public properties



        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("vout")]
        public int VOut { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("bcconfirmations")]
        public int BCConfirmations { get; set; }

        [JsonProperty("blockhash")]
        public string BlockHash { get; set; }

        [JsonProperty("blockindex")]
        public uint BlockIndex { get; set; }

        [JsonProperty("blocktime")]
        public ulong BlockTime { get; set; }

        [JsonProperty("txid")]
        public string TransactionId { get; set; }

        [JsonProperty("time")]
        public ulong Time { get; set; }

        [JsonProperty("timereceived")]
        public ulong TimeReceived { get; set; }



        #endregion
    }
}
