using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticatedAPI
{
    public static class CAuthenticatedApi
    {
        #region Получение информации об аккаунте пользователя

        public class CUserInfoBalances
        {
            public decimal Usd { get; set; }
            public decimal Eur { get; set; }
            public decimal Rub { get; set; }
            public decimal Uah { get; set; }
            public decimal Btc { get; set; }
            public decimal Ltc { get; set; }
            public decimal Doge { get; set; }
            public decimal Dash { get; set; }
            public decimal Eth { get; set; }
            public decimal Waves { get; set; }
        }

        public class CUserInfoReserved
        {
            public decimal Usd { get; set; }
            public decimal Eur { get; set; }
            public decimal Rub { get; set; }
            public decimal Uah { get; set; }
            public decimal Btc { get; set; }
            public decimal Ltc { get; set; }
            public decimal Doge { get; set; }
            public decimal Dash { get; set; }
            public decimal Eth { get; set; }
            public decimal Waves { get; set; }
        }

        public class CUserInfoResult
        {
            public int Uid { get; set; }
            public int Server_Date { get; set; }
            public CUserInfoBalances Balances { get; set; }
            public CUserInfoReserved Reserved { get; set; }
        }
        #endregion

        #region Получение списока открытых ордеров пользователя

        public class CUserOpenOrdersBtcusd
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtceur
        {
            public uint  Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtcrub
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtcuah
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashbtc
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashusd
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthbtc
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthusd
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDogebtc
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersLtcbtc
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthrub
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEtheur
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersLtcrub
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashrub
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthltc
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersUsdrub
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersWavesbtc
        {
            public uint Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }

        public class CUserOpenOrdersResult
        {
            public List<CUserOpenOrdersBtcusd> Btc_Usd { get; set; }
            public List<CUserOpenOrdersBtcusd> Btc_Eur { get; set; }
            public List<CUserOpenOrdersBtcusd> Btc_Rub { get; set; }
            public List<CUserOpenOrdersBtcusd> Btc_Uah { get; set; }
            public List<CUserOpenOrdersBtcusd> Dash_Btc { get; set; }
            public List<CUserOpenOrdersBtcusd> Dash_Usd { get; set; }
            public List<CUserOpenOrdersBtcusd> Eth_Btc { get; set; }
            public List<CUserOpenOrdersBtcusd> Eth_Usd { get; set; }
            public List<CUserOpenOrdersBtcusd> Doge_Btc { get; set; }
            public List<CUserOpenOrdersBtcusd> Ltc_Btc { get; set; }
            public List<CUserOpenOrdersBtcusd> Eth_Rub { get; set; }
            public List<CUserOpenOrdersBtcusd> Eth_Eur { get; set; }
            public List<CUserOpenOrdersBtcusd> Ltc_Rub { get; set; }
            public List<CUserOpenOrdersBtcusd> Dash_Rub { get; set; }
            public List<CUserOpenOrdersBtcusd> Eth_Ltc { get; set; }
            public List<CUserOpenOrdersBtcusd> Usd_Rub { get; set; }
            public List<CUserOpenOrdersBtcusd> Waves_Btc { get; set; }
        }

        #endregion

        #region Создание ордера
        public class COrderCreateResult
        {
            public bool Result { get; set; }
            public string Error { get; set; }
            public int OrderId { get; set; }
        }
        #endregion
    }
}
