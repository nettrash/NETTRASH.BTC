using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    /// <summary>
    /// {"result":{"":-26147.68000000,"SIBPAY":20000.00000000,"SIBSeller":15.00000000,"YOBit.net =>":1147.12704565,"Бро":5000.00000000},"error":null,"id":"131448575038134316"}
    /// </summary>
    [JsonObject]
    public class ListAccountsResponse : BaseResponse
    {
        #region Public properties



        [JsonProperty("result")]
        public Dictionary<string, decimal> Accounts { get; set; }



        #endregion
    }
}
