using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExmoAPI.Public_API
{
    //
    public class CTrades : ITrades
    {
        [JsonProperty("trade_id")]
        public int TradeId { get; set; }
        [JsonProperty("type")]
        public string Type { get ; set; }
        [JsonProperty("price")]
        public decimal Price { get ; set ; }
        [JsonProperty("quantity")]
        public decimal Quantity { get ; set ; }
        [JsonProperty("amount")]
        public decimal Amount { get ; set ; }
        [JsonProperty("date")]
        public int Date { get ; set ; }
    }
}
