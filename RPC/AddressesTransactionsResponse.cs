using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    [JsonObject]
    public class AddressesTransactionsResponse : BaseResponse
    {
        #region Public properties



        [JsonProperty(PropertyName = "result")]
        public string[] TransactionIDs { get; set; }



        #endregion
    }
}
