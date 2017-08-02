namespace ExmoAPI.Public_API
{
    //Настройки валютных пар
    public interface IPairSettings
    {
        decimal MinQuantity { get; set; }
        decimal MaxQuantity { get; set; }
        decimal MinPrice { get; set; }
        decimal MaxPrice { get; set; }
        decimal MaxAmount { get; set; }
        decimal MinAmount { get; set; }
    }
}