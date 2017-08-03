using System;
using ExmoAPI.Authenticated_API.Interfeces;
using Newtonsoft.Json;

namespace ExmoAPI.Authenticated_API.Classes
{
    //Получение информации об аккаунте пользователя
    public class CUserInfo
    {
        [JsonProperty("uid")]
        public int Uid { get; set; }
        [JsonProperty("server_date")]
        public int ServerDate { get; set; }
        [JsonProperty("balances")]
        public Balances Balances { get; set; }
        [JsonProperty("reserved")]
        public Reserved Reserved { get; set; }
    }

    public class Balances : IBalances
    {
        [JsonProperty("USD")]
        public decimal Usd { get; set; }
        [JsonProperty("EUR")]
        public decimal Eur { get; set; }
        [JsonProperty("RUB")]
        public decimal Rub { get; set; }
        [JsonProperty("UAH")]
        public decimal Uah { get; set; }
        [JsonProperty("BTC")]
        public decimal Btc { get; set; }
        [JsonProperty("LTC")]
        public decimal Ltc { get; set; }
        [JsonProperty("DOGE")]
        public decimal Doge { get; set; }
        [JsonProperty("DASH")]
        public decimal Dash { get; set; }
        [JsonProperty("ETH")]
        public decimal Eth { get; set; }
        [JsonProperty("WAVES")]
        public decimal Waves { get; set; }
        [JsonProperty("ZEC")]
        public decimal Zec { get; set; }
    }
    public class Reserved : IReserved
    {
        [JsonProperty("USD")]
        public decimal Usd { get; set; }
        [JsonProperty("EUR")]
        public decimal Eur { get; set; }
        [JsonProperty("RUB")]
        public decimal Rub { get; set; }
        [JsonProperty("UAH")]
        public decimal Uah { get; set; }
        [JsonProperty("BTC")]
        public decimal Btc { get; set; }
        [JsonProperty("LTC")]
        public decimal Ltc { get; set; }
        [JsonProperty("DOGE")]
        public decimal Doge { get; set; }
        [JsonProperty("DASH")]
        public decimal Dash { get; set; }
        [JsonProperty("ETH")]
        public decimal Eth { get; set; }
        [JsonProperty("WAVES")]
        public decimal Waves { get; set; }
        [JsonProperty("ZEC")]
        public decimal Zec { get; set; }
    }
}