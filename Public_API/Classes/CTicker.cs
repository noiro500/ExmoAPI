using System;
using Newtonsoft.Json;

namespace ExmoAPI.Public_API
{
    public class CTicker : ITicker
    {
        [JsonProperty("buy_price")]
        public decimal BuyPrice { get  ; set  ; }
        [JsonProperty("sell_price")]
        public decimal SellPrice { get  ; set  ; }
        [JsonProperty("last_trade")]
        public decimal LastTrade { get  ; set  ; }
        [JsonProperty("high")]
        public decimal High { get  ; set  ; }
        [JsonProperty("low")]
        public decimal Low { get  ; set  ; }
        [JsonProperty("avg")]
        public decimal Avg { get  ; set  ; }
        [JsonProperty("vol")]
        public decimal Vol { get  ; set  ; }
        [JsonProperty("vol_curr")]
        public decimal VolCurr { get  ; set  ; }
        [JsonProperty("updated")]
        public int Updated { get  ; set  ; }
    }
}