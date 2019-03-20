using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTRASH.BTC.Rate
{
    //{"buy_price":"150001.76011","sell_price":"150835.4329","last_trade":"150835.4329","high":"158500","low":"147622.94137","avg":"154048.86545049","vol":"101.87583848","vol_curr":"15676593.08873092","updated":1501097571}
    [JsonObject]
    public class ExmoRate
    {
        #region Public properties



        public decimal buy_price { get; set; }

        public decimal sell_price { get; set; }



        #endregion
    }
}
