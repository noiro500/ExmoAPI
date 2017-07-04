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
            public int ServerDate { get; set; }
            public CUserInfoBalances Balances { get; set; }
            public CUserInfoReserved Reserved { get; set; }
        }
        #endregion

        #region Получение списока открытых ордеров пользователя

        public class CUserOpenOrdersBtcusd
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersBtceur
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersBtcrub
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersBtcuah
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersDashbtc
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersDashusd
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersEthbtc
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersEthusd
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersDogebtc
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersLtcbtc
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersEthrub
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersEtheur
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersLtcrub
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersDashrub
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersEthltc
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersUsdrub
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }
        public class CUserOpenOrdersWavesbtc
        {
            public string OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Amount { get; set; }
        }

        public class CUserOpenOrdersResult
        {
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
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
