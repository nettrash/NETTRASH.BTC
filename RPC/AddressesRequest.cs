using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    /// <summary>
    /// Для запроса баланса по адресу надо запускать демона с ключем -addressindex -reindex=1 (последний для переиндексации пр первом старте)
    /// </summary>
    [JsonObject]
    public class AddressesRequest
    {
        #region Public properties


        [JsonProperty(PropertyName = "addresses")]
        public string[] Addresses { get; set; }



        #endregion
        #region Public constructors



        public AddressesRequest()
        {

        }

        public AddressesRequest(string[] addresses)
        {
            Addresses = addresses;
        }



        #endregion
        #region Public methods



        public static string Serialize(string[] Addresses)
        {
            AddressesRequest rq = new AddressesRequest();
            rq.Addresses = Addresses;
            return Newtonsoft.Json.JsonConvert.SerializeObject(rq);
        }



        #endregion
    }
}
