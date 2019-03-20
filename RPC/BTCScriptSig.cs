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
        "asm": "3045022100eed5c3c0294582448c74fdb058fc4e1a1ea196c980fd23373d6b3a72b8679c5d022068c8b3f83c4cbe241b65977d300aa708b98d21365179379e642516f08d28ad08[ALL] 035f9fdc6bf1d0dcbbed565229794a5c58b62458904f374598d4c789318ef700fb",
        "hex": "483045022100eed5c3c0294582448c74fdb058fc4e1a1ea196c980fd23373d6b3a72b8679c5d022068c8b3f83c4cbe241b65977d300aa708b98d21365179379e642516f08d28ad080121035f9fdc6bf1d0dcbbed565229794a5c58b62458904f374598d4c789318ef700fb"
      }
         */
    [JsonObject]
    public class BTCScriptSig
    {
        #region Public properties



        public string asm { get; set; }

        public string hex { get; set; }



        #endregion
    }
}
