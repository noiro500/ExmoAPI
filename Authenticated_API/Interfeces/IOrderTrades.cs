using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExmoAPI.Authenticated_API.Interfeces
{
    //Получение истории сделок ордера
    public interface IOrderTrades
    {
        string Type { get;}
        string InCurrency { get;}
        decimal InAmount { get;}
        string OutCurrency { get;}
        decimal OutAmount { get;}
        //List<ITrade> Trades { get;}
    }

    public interface ITrade
    {
        decimal TradeId { get;}
        decimal Date { get;}
        string Type { get;}
        string Pair { get;}
        decimal OrderId { get;}
        decimal Quantity { get;}
        decimal Price { get;}
        decimal Amount { get;}
    }
}