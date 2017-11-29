using ExmoAPI.Public_API.Interfaces;
using Newtonsoft.Json;

namespace ExmoAPI.Public_API.Classes
{
    public class CTrades : ITrades
    {
        [JsonProperty("trade_id")]
        public int TradeId { get; private set; }
        [JsonProperty("type")]
        public string Type { get ; private set; }
        [JsonProperty("price")]
        public decimal Price { get ; private set ; }
        [JsonProperty("quantity")]
        public decimal Quantity { get ; private set ; }
        [JsonProperty("amount")]
        public decimal Amount { get ; private set; }
        [JsonProperty("date")]
        public double Date { get ; private set ; }
    }
}
