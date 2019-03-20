using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    [JsonObject]
    public class BaseResponse
    {
        #region Public properties



        [JsonProperty("error")]
        public ErrorType Error { get; set; }

        [JsonProperty("id")]
        public ulong Id { get; set; }



        #endregion
    }
}
