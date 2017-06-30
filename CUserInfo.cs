using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmoAPI
{
    public class CBalances
    {
        public string BTC { get; set; }
        public string USD { get; set; }
        public string EUR { get; set; }
        public string RUB { get; set; }
        public string UAH { get; set; }
        public string LTC { get; set; }
        public string DOGE { get; set; }
        public string DASH { get; set; }
        public string ETH { get; set; }
        public string WAVES { get; set; }
    }

    public class CReserved
    {
        public string BTC { get; set; }
        public string USD { get; set; }
        public string EUR { get; set; }
        public string RUB { get; set; }
        public string UAH { get; set; }
        public string LTC { get; set; }
        public string DOGE { get; set; }
        public string DASH { get; set; }
        public string ETH { get; set; }
        public string WAVES { get; set; }
    }

    public class CUserInfo
    {
        public int uid { get; set; }
        public int server_date { get; set; }
        public CBalances balances { get; set; }
        public CReserved reserved { get; set; }
    }
}
