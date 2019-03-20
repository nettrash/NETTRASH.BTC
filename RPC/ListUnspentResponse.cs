﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    [JsonObject]
    public class ListUnspentResponse : BaseResponse
    {
        #region Public properties



        [JsonProperty("result")]
        public BTCUnpsentTransaction[] UnspentTransactions { get; set; }



        #endregion
    }
}
