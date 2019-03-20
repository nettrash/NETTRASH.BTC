using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    /// <summary>
    /// {"code":-6,"message":"Account has insufficient funds"}
    /// </summary>
    [JsonObject]
    public class ErrorType
    {
        #region Public properties



        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }



        #endregion
    }
}
