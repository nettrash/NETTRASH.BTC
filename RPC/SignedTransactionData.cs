using Newtonsoft.Json;

namespace NETTRASH.BTC.RPC
{
    [JsonObject]
    public class SignedTransactionData
    {
        #region Public properties



        public string hex { get; set; }

        public bool complete { get; set; }



        #endregion
    }
}
