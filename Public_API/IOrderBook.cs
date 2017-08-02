using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExmoAPI.Public_API
{
    //Книга ордеров по валютной паре
    public interface IOrderBook
    {
        decimal AskQuantity { get; set; }
        decimal AskAmount { get; set; }
        decimal AskTop { get; set; }
        decimal BidQuantity { get; set; }
        decimal BidAmount { get; set; }
        decimal BidTop { get; set; }
        List<List<decimal>> Ask { get; set; }
        List<List<decimal>> Bid { get; set; }
    }
}