using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    [JsonObject]
    public class Request
    {
        #region Public properties



        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public object[] Parameters { get; set; }

        [JsonProperty("id")]
        public string RequestId { get; set; }



        #endregion
        #region Public constructors



        public Request()
        {
            RequestId = DateTime.UtcNow.ToFileTime().ToString();
        }



        #endregion
        #region Public methods



        public override string ToString()
        {
            if (Parameters == null)
                Parameters = new string[0];
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }



        #endregion
    }
}
