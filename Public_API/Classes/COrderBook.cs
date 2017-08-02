using System.Collections.Generic;
using ExmoAPI.Public_API.Interfaces;
using Newtonsoft.Json;

namespace ExmoAPI.Public_API.Classes
{
    public class COrderBook : IOrderBook
    {
        [JsonProperty("ask_quantity")]
        public decimal AskQuantity { get; set ; }
        [JsonProperty("ask_amount")]
        public decimal AskAmount { get; set; }
        [JsonProperty("ask_top")]
        public decimal AskTop { get; set; }
        [JsonProperty("bid_quantity")]
        public decimal BidQuantity { get; set; }
        [JsonProperty("bid_amount")]
        public decimal BidAmount { get; set; }
        [JsonProperty("bid_top")]
        public decimal BidTop { get; set; }
        [JsonProperty("ask")]
        public List<List<decimal>> Ask { get; set; }
        [JsonProperty("bid")]
        public List<List<decimal>> Bid { get; set; }
    }
}