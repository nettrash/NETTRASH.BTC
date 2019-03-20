using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    [JsonObject]
    public class GetAddressesByAccountResponse : BaseResponse
    {
        #region Public properties



        [JsonProperty("result")]
        public List<string> Addresses { get; set; }



        #endregion
    }
}
