namespace ExmoAPI.Authenticated_API
{
    //Получение списока открытых ордеров пользователя
    public interface IUserOpenOrders
    {
        decimal OrderId { get;}
        ulong CreatedTime { get;}
        string Type { get;}
        string Pair { get;}
        decimal Price { get;}
        decimal Quantity { get;}
        decimal Amount { get;}
    }
}