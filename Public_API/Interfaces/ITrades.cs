namespace ExmoAPI.Public_API.Interfaces
{
    // Список сделок по валютной паре
    public interface ITrades
    {
        int TradeId { get; set; }
        string Type { get; set; }
        decimal Price { get; set; }
        decimal Quantity { get; set; }
        decimal Amount { get; set; }
        int Date { get; set; }
    }
    
}
