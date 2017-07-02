using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PublicAPI
{
    public static class MethodsPublicAPI
    {
        #region Список сделок по валютной паре BTC_USB
        public class CTradeBTCUSD
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public string price { get; set; }
            public string quantity { get; set; }
            public string amount { get; set; }
            public int date { get; set; }
        }

        public class CBtcUsdTradeResult
        {
            [JsonProperty(PropertyName = "BTC_USD")]
            public List<CTradeBTCUSD> BtcUsd { get; set; }
            public void ShowPrice()
            {
                foreach (var item in BtcUsd)
                {
                    Console.WriteLine(item.price);
                }
            }
        }
        #endregion
        #region Книга ордеров по валютной паре
        public class COrderBookBTCUSD
        {
            public string ask_quantity { get; set; }
            public string ask_amount { get; set; }
            public string ask_top { get; set; }
            public string bid_quantity { get; set; }
            public string bid_amount { get; set; }
            public string bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class CBtcUsdOrderBookResult
        {
            [JsonProperty(PropertyName = "BTC_USD")]
            public COrderBookBTCUSD BtcUsd { get; set; }
        }
        #endregion
    }
}
