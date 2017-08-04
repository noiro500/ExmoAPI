namespace ExmoAPI.Authenticated_API.Interfeces
{
    //Получение информации об аккаунте пользователя
    public interface IBalances
    {
        decimal Usd { get;}
        decimal Eur { get;}
        decimal Rub { get;}
        decimal Uah { get;}
        decimal Btc { get;}
        decimal Ltc { get;}
        decimal Doge { get;}
        decimal Dash { get;}
        decimal Eth { get;}
        decimal Waves { get;}
        decimal Zec { get;}
    }
    public interface IReserved
    {
        decimal Usd { get;}
        decimal Eur { get;}
        decimal Rub { get;}
        decimal Uah { get;}
        decimal Btc { get;}
        decimal Ltc { get;}
        decimal Doge { get;}
        decimal Dash { get;}
        decimal Eth { get;}
        decimal Waves { get;}
        decimal Zec { get;}
    }

    public interface IUserInfo
    {
       int Uid { get;}
        int ServerDate { get;}
        IBalances Balances { get;}
        IReserved Reserved { get;}
    }
}