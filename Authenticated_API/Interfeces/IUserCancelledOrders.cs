namespace ExmoAPI.Authenticated_API.Interfeces
{
    //Получение отмененных ордеров пользователя
    public interface IUserCancelledOrders
    {
        decimal Date { get;}
        decimal OrderId { get; }
        string OrderType { get; }
        string Pair { get; }
        decimal Price { get;}
        decimal Quantity { get;}
        decimal Amount { get;}
    }
}