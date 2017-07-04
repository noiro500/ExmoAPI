using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticatedAPI
{
    public static class CAuthenticatedAPI
    {
        #region Получение информации об аккаунте пользователя

        public class CUser_infoBalances
        {
            public decimal USD { get; set; }
            public decimal EUR { get; set; }
            public decimal RUB { get; set; }
            public decimal UAH { get; set; }
            public decimal BTC { get; set; }
            public decimal LTC { get; set; }
            public decimal DOGE { get; set; }
            public decimal DASH { get; set; }
            public decimal ETH { get; set; }
            public decimal WAVES { get; set; }
        }

        public class CUser_infoReserved
        {
            public decimal USD { get; set; }
            public decimal EUR { get; set; }
            public decimal RUB { get; set; }
            public decimal UAH { get; set; }
            public decimal BTC { get; set; }
            public decimal LTC { get; set; }
            public decimal DOGE { get; set; }
            public decimal DASH { get; set; }
            public decimal ETH { get; set; }
            public decimal WAVES { get; set; }
        }

        public class CUser_infoResult
        {
            public int uid { get; set; }
            public int server_date { get; set; }
            public CUser_infoBalances balances { get; set; }
            public CUser_infoReserved reserved { get; set; }
        }
        #endregion
    }
}
