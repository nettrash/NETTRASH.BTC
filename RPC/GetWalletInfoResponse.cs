using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.RPC
{
	/// <summary>
	/// </summary>
	public class GetWalletInfoResponse
	{
		#region Public properties



		public GetWalletInfoResult result { get; set; }



		#endregion
	}


	public class GetWalletInfoResult
	{
		#region Public properties



		public string walletname { get; set; }

		public int walletversion { get; set; }

		public decimal balance { get; set; }

		public decimal unconfirmed_balance { get; set; }

		public decimal immature_balance { get; set; }

		public int txcount { get; set; }

		public int keypoololdest { get; set; }

		public int keypoolsize { get; set; }

		public int keypoolsize_hd_internal { get; set; }

		public decimal paytxfee { get; set; }

		public string hdseedid { get; set; }

		public string hdmasterkeyid { get; set; }

		public bool private_keys_enabled { get; set; }



		#endregion
	}

}
