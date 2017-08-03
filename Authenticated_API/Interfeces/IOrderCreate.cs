namespace ExmoAPI.Authenticated_API.Interfeces
{
    public interface IOrderCreate
    {
        bool Result { get; set; }
        string Error { get; set; }
        decimal OrderId { get; set; }
    }
}