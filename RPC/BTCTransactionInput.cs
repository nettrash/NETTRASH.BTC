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
      "txid": "d854f1eb2a8f5e4fe2da6ab3a9486a0bbdfb911390e86188b11dae3ec0b83e43",
      "vout": 0,
      "scriptSig": {
        "asm": "3045022100eed5c3c0294582448c74fdb058fc4e1a1ea196c980fd23373d6b3a72b8679c5d022068c8b3f83c4cbe241b65977d300aa708b98d21365179379e642516f08d28ad08[ALL] 035f9fdc6bf1d0dcbbed565229794a5c58b62458904f374598d4c789318ef700fb",
        "hex": "483045022100eed5c3c0294582448c74fdb058fc4e1a1ea196c980fd23373d6b3a72b8679c5d022068c8b3f83c4cbe241b65977d300aa708b98d21365179379e642516f08d28ad080121035f9fdc6bf1d0dcbbed565229794a5c58b62458904f374598d4c789318ef700fb"
      },
      "sequence": 4294967294
    }

         */
    [JsonObject]
    public class BTCTransactionInput
    {
        #region Public properties



        public string txid { get; set; }

        public uint vout { get; set; }

        public BTCScriptSig scriptSig { get; set; }

        public ulong sequence { get; set; }



        #endregion
    }
}
