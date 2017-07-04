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
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtceur
        {
            public uint  OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtcrub
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersBtcuah
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashbtc
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashusd
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthbtc
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthusd
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDogebtc
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersLtcbtc
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthrub
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEtheur
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersLtcrub
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersDashrub
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersEthltc
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersUsdrub
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }
        public class CUserOpenOrdersWavesbtc
        {
            public uint OrderId { get; set; }
            public string Created { get; set; }
            public string Type { get; set; }
            public string Pair { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public decimal Amount { get; set; }
        }

        public class CUserOpenOrdersResult
        {
            public List<CUserOpenOrdersBtcusd> BtcUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcEur { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcRub { get; set; }
            public List<CUserOpenOrdersBtcusd> BtcUah { get; set; }
            public List<CUserOpenOrdersBtcusd> DashBtc { get; set; }
            public List<CUserOpenOrdersBtcusd> DashUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> EthBtc { get; set; }
            public List<CUserOpenOrdersBtcusd> EthUsd { get; set; }
            public List<CUserOpenOrdersBtcusd> DogeBtc { get; set; }
            public List<CUserOpenOrdersBtcusd> LtcBtc { get; set; }
            public List<CUserOpenOrdersBtcusd> EthRub { get; set; }
            public List<CUserOpenOrdersBtcusd> EthEur { get; set; }
            public List<CUserOpenOrdersBtcusd> LtcRub { get; set; }
            public List<CUserOpenOrdersBtcusd> DashRub { get; set; }
            public List<CUserOpenOrdersBtcusd> EthLtc { get; set; }
            public List<CUserOpenOrdersBtcusd> UsdRub { get; set; }
            public List<CUserOpenOrdersBtcusd> WavesBtc { get; set; }
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
