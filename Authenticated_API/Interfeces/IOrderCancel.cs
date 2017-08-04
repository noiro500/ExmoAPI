namespace ExmoAPI.Authenticated_API.Interfeces
{
    public interface IOrderCancel
    {
        bool Result { get; set; }
        string Error { get; set; }
    }
}