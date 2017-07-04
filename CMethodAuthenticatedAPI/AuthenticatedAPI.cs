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
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtceur
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtcrub
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtcuah
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashbtc
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashusd
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthbtc
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthusd
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDogebtc
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersLtcbtc
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthrub
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEtheur
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersLtcrub
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashrub
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthltc
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersUsdrub
        {
            public UInt64 Order_Id { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersWavesbtc
        {
            public UInt64 Order_Id { get; set; }
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
            public List<CUserOpenOrdersBtceur> Btc_Eur { get; set; }
            public List<CUserOpenOrdersBtcrub> Btc_Rub { get; set; }
            public List<CUserOpenOrdersBtcuah> Btc_Uah { get; set; }
            public List<CUserOpenOrdersDashbtc> Dash_Btc { get; set; }
            public List<CUserOpenOrdersDashusd> Dash_Usd { get; set; }
            public List<CUserOpenOrdersDashusd> Eth_Btc { get; set; }
            public List<CUserOpenOrdersEthusd> Eth_Usd { get; set; }
            public List<CUserOpenOrdersDogebtc> Doge_Btc { get; set; }
            public List<CUserOpenOrdersLtcbtc> Ltc_Btc { get; set; }
            public List<CUserOpenOrdersEthrub> Eth_Rub { get; set; }
            public List<CUserOpenOrdersEtheur> Eth_Eur { get; set; }
            public List<CUserOpenOrdersLtcrub> Ltc_Rub { get; set; }
            public List<CUserOpenOrdersDashrub> Dash_Rub { get; set; }
            public List<CUserOpenOrdersEthltc> Eth_Ltc { get; set; }
            public List<CUserOpenOrdersUsdrub> Usd_Rub { get; set; }
            public List<CUserOpenOrdersWavesbtc> Waves_Btc { get; set; }
        }

        #endregion

        #region Создание ордера
        public class COrderCreateResult
        {
            public bool Result { get; set; }
            public string Error { get; set; }
            public int Order_Id { get; set; }
        }
        #endregion

        #region Отмена ордера

        public class COrderCancelResult
        {
            public bool result { get; set; }
            public string error { get; set; }
        }

        #endregion
    }
}
