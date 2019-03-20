using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
    public class API
    {
		#region Private properties



		private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();



		#endregion
		#region Public properties



		public string Host { get; set; }

        public int Port { get; set; }

        public string User { get; set; }

        public string Password { get; set; }



        #endregion
        #region Public constructors



        public API()
        {
            Host = Properties.Settings.Default.RPCHost;
            Port = Properties.Settings.Default.RPCPort;
            User = Properties.Settings.Default.RPCUser;
            Password = Properties.Settings.Default.RPCPassword;
        }

        public API(string sHost, int nPort, string sUser, string sPassword)
        {
            Host = sHost;
            Port = nPort;
            User = sUser;
            Password = sPassword;
        }



        #endregion
        #region Private methods



        private async Task<string> _postAsync(Request request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StringContent content = new StringContent(request.ToString(), Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{User}:{Password}")));

                var response = await client.PostAsync(new Uri($"http://{Host}:{Port}"), content, cancellationToken);

                string sResponse = await response.Content.ReadAsStringAsync();

				_logger.Trace(sResponse);

				return sResponse;
            }
        }



        #endregion
        #region Public methods



        public async Task<GetWalletInfoResponse> GetWalletInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "getwalletinfo" };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetWalletInfoResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<ListAccountsResponse> ListAccountsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "listaccounts" };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListAccountsResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<GetAddressesByAccountResponse> GetAddressesByAccount(string Account, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "getaddressesbyaccount", Parameters = new string[] { Account } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetAddressesByAccountResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<SendFromAccountToAddressResponse> SendFromAccountToAddressAsync(string sAccount, string sAddress, decimal nAmount, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "sendfrom", Parameters = new string[] { sAccount, sAddress, nAmount.ToString("0.00000000", System.Globalization.CultureInfo.InvariantCulture) } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SendFromAccountToAddressResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<GetNewAddressResponse> GetNewAddressAsync(string sAccount, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "getnewaddress", Parameters = new string[] { sAccount } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetNewAddressResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<ListTransactionsResponse> ListTransactionsAsync(string sAccount, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "listtransactions", Parameters = new string[] { sAccount } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListTransactionsResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<MoveResponse> MoveAsync(string sFromAccount, string sToAccount, decimal nAmount, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "move", Parameters = new string[] { sFromAccount, sToAccount, nAmount.ToString("0.00000000", System.Globalization.CultureInfo.InvariantCulture) } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MoveResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<AddressesTransactionsResponse> AddressesTransactionsAsync(string[] Addresses, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "getaddresstxids", Parameters = new AddressesRequest[] { new AddressesRequest(Addresses) } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AddressesTransactionsResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<GetRawTransactionResponse> GetRawTransactionAsync(string sTransactionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "getrawtransaction", Parameters = new object[] { sTransactionId, 1 } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetRawTransactionResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<DecodeRawTransactionResponse> DecodeRawTransactionAsync(string sTransactionRawData, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "decoderawtransaction", Parameters = new object[] { sTransactionRawData } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DecodeRawTransactionResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<ListUnspentResponse> ListUnspentAsync(string[] addresses, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "listunspent", Parameters = new object[] { 0 /*minconf*/, 999999 /*maxconf*/, addresses } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ListUnspentResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<CreateRawTransactionResponse> CreateRawTransactionAsync(object[] inputs, object output, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "createrawtransaction", Parameters = new object[] { inputs, output } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CreateRawTransactionResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<SignRawTransactionResponse> SignRawTransactionAsync(string sRawData, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "signrawtransaction", Parameters = new object[] { sRawData } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SignRawTransactionResponse>(await _postAsync(rq, cancellationToken));
        }

        public async Task<SendRawTransactionResponse> SendRawTransactionAsync(string sSignedRawData, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Request rq = new Request { Method = "sendrawtransaction", Parameters = new object[] { sSignedRawData } };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SendRawTransactionResponse>(await _postAsync(rq, cancellationToken));
        }



        #endregion
    }
}
