using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    /*
     [                   (array of json object)
  {
    "txid" : "txid",          (string) the transaction id 
    "vout" : n,               (numeric) the vout value
    "address" : "address",    (string) the bitcoin address
    "account" : "account",    (string) DEPRECATED. The associated account, or "" for the default account
    "scriptPubKey" : "key",   (string) the script key
    "amount" : x.xxx,         (numeric) the transaction output amount in BTC
    "confirmations" : n,      (numeric) The number of confirmations
    "redeemScript" : n        (string) The redeemScript if scriptPubKey is P2SH
    "spendable" : xxx,        (bool) Whether we have the private keys to spend this output
    "solvable" : xxx,         (bool) Whether we know how to spend this output, ignoring the lack of keys
    "safe" : xxx              (bool) Whether this output is considered safe to spend. Unconfirmed transactions
                              from outside keys and unconfirmed replacement transactions are considered unsafe
                              and are not eligible for spending by fundrawtransaction and sendtoaddress.
  }
  ,...
]
         */
    [JsonObject]
    public class BTCUnpsentTransaction
    {
        #region Public properties



        public string txid { get; set; }

        public uint vout { get; set; }

        public string address { get; set; }

        public string account { get; set; }

        public string scriptPubKey { get; set; }

        public decimal amount { get; set; }

        public uint confirmations { get; set; }

        public string redeemScript { get; set; }

        public bool spendable { get; set; }

        public bool solvable { get; set; }

        public bool safe { get; set; }



        #endregion
    }
}
