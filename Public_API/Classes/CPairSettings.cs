using ExmoAPI.Public_API.Interfaces;
using Newtonsoft.Json;

namespace ExmoAPI.Public_API.Classes
{
    public class CPairSettings : IPairSettings
    {
        [JsonProperty("min_quantity")]
        public decimal MinQuantity { get; set; }
        [JsonProperty("max_quantity")]
        public decimal MaxQuantity { get; set; }
        [JsonProperty("min_price")]
        public decimal MinPrice { get; set; }
        [JsonProperty("max_price")]
        public decimal MaxPrice { get; set; }
        [JsonProperty("max_amount")]
        public decimal MaxAmount { get; set; }
        [JsonProperty("min_amount")]
        public decimal MinAmount { get; set; }
    }
}