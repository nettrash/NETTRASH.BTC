using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    /*
{
      "value": 0.00010000,
      "n": 0,
      "scriptPubKey": {
        "asm": "OP_DUP OP_HASH160 297e644bdf7d54d8db8c5515df19491cdfd84d07 OP_EQUALVERIFY OP_CHECKSIG",
        "hex": "76a914297e644bdf7d54d8db8c5515df19491cdfd84d0788ac",
        "reqSigs": 1,
        "type": "pubkeyhash",
        "addresses": [
          "14nQ7imJpf4r6ktKjbqSoAcGZLWjUegFqa"
        ]
      }
    }
    */
    [JsonObject]
    public class BTCTransactionOutput
    {
        #region Public properties



        public decimal value { get; set; }

        public uint n { get; set; }

        public BTCScriptPubKey scriptPubKey { get; set; }



        #endregion
    }
}
