namespace ExmoAPI.Public_API.Interfaces
{
    // Список сделок по валютной паре
    public interface ITrades
    {
        int TradeId { get;}
        string Type { get; }
        decimal Price { get; }
        decimal Quantity { get;}
        decimal Amount { get; }
        double Date { get; }
    }
    
}
