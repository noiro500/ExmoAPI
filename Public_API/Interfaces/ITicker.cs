namespace ExmoAPI.Public_API.Interfaces
{
    //Cтатистика цен и объемов торгов по валютным парам
    public interface ITicker
    {
        decimal BuyPrice { get; set; }
        decimal SellPrice { get; set; }
        decimal LastTrade { get; set; }
        decimal High { get; set; }
        decimal Low { get; set; }
        decimal Avg { get; set; }
        decimal Vol { get; set; }
        decimal VolCurr { get; set; }
        decimal Updated { get; set; }
    }
}