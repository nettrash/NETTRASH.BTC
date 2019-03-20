using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    /*
     
￼
{
  "txid": "5781f691c4b680ed4299640014bdd85f20a6c1f6d2762d99246551c777db01aa",
  "hash": "5781f691c4b680ed4299640014bdd85f20a6c1f6d2762d99246551c777db01aa",
  "version": 2,
  "size": 226,
  "vsize": 226,
  "locktime": 511947,
  "vin": [
    {
      "txid": "d854f1eb2a8f5e4fe2da6ab3a9486a0bbdfb911390e86188b11dae3ec0b83e43",
      "vout": 0,
      "scriptSig": {
        "asm": "3045022100eed5c3c0294582448c74fdb058fc4e1a1ea196c980fd23373d6b3a72b8679c5d022068c8b3f83c4cbe241b65977d300aa708b98d21365179379e642516f08d28ad08[ALL] 035f9fdc6bf1d0dcbbed565229794a5c58b62458904f374598d4c789318ef700fb",
        "hex": "483045022100eed5c3c0294582448c74fdb058fc4e1a1ea196c980fd23373d6b3a72b8679c5d022068c8b3f83c4cbe241b65977d300aa708b98d21365179379e642516f08d28ad080121035f9fdc6bf1d0dcbbed565229794a5c58b62458904f374598d4c789318ef700fb"
      },
      "sequence": 4294967294
    }
  ],
  "vout": [
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
    }, 
    {
      "value": 0.01950401,
      "n": 1,
      "scriptPubKey": {
        "asm": "OP_DUP OP_HASH160 73a27fa108ea60bfe4a83a1280c9e7e9c62a4133 OP_EQUALVERIFY OP_CHECKSIG",
        "hex": "76a91473a27fa108ea60bfe4a83a1280c9e7e9c62a413388ac",
        "reqSigs": 1,
        "type": "pubkeyhash",
        "addresses": [
          "1BYRNf9gzJC2c9qxjxwVqpxNVwyYyMeuoj"
        ]
      }
    }
  ]
}

         */
    [JsonObject]
    public class BTCTransaction
    {
        #region Public properties



        public string txid { get; set; }

        public string hash { get; set; }

        public uint version { get; set; }

        public uint size { get; set; }

        public uint vsize { get; set; }

        public ulong locktime { get; set; }

        public BTCTransactionInput[] vin { get; set; }

        public BTCTransactionOutput[] vout { get; set; }



        #endregion
    }
}
