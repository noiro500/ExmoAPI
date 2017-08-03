namespace ExmoAPI.Authenticated_API.Interfeces
{
    public interface IBalances
    {
        decimal Usd { get; set; }
        decimal Eur { get; set; }
        decimal Rub { get; set; }
        decimal Uah { get; set; }
        decimal Btc { get; set; }
        decimal Ltc { get; set; }
        decimal Doge { get; set; }
        decimal Dash { get; set; }
        decimal Eth { get; set; }
        decimal Waves { get; set; }
        decimal Zec { get; set; }
    }
    public interface IReserved
    {
        decimal Usd { get; set; }
        decimal Eur { get; set; }
        decimal Rub { get; set; }
        decimal Uah { get; set; }
        decimal Btc { get; set; }
        decimal Ltc { get; set; }
        decimal Doge { get; set; }
        decimal Dash { get; set; }
        decimal Eth { get; set; }
        decimal Waves { get; set; }
        decimal Zec { get; set; }
    }

    public interface IUserInfo
    {
       int Uid { get; set; }
        int ServerDate { get; set; }
        IBalances Balances { get; set; }
        IReserved Reserved { get; set; }
    }
}