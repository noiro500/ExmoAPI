using System;
using ExmoAPI.Authenticated_API.Interfeces;
using Newtonsoft.Json;

namespace ExmoAPI.Authenticated_API.Classes
{
    //Получение информации об аккаунте пользователя
    public class CUserInfo
    {
        [JsonProperty("uid")]
        public int Uid { get;private set;}
        [JsonProperty("server_date")]
        public ulong ServerDate { get;private set;}
        [JsonProperty("balances")]
        public Balances Balances { get;private set;}
        [JsonProperty("reserved")]
        public Reserved Reserved { get;private set;}
    }

    public class Balances : IBalances
    {
        [JsonProperty("USD")]
        public decimal Usd { get;private set;}
        [JsonProperty("EUR")]
        public decimal Eur { get;private set;}
        [JsonProperty("RUB")]
        public decimal Rub { get;private set;}
        [JsonProperty("UAH")]
        public decimal Uah { get;private set;}
        [JsonProperty("BTC")]
        public decimal Btc { get;private set;}
        [JsonProperty("LTC")]
        public decimal Ltc { get;private set;}
        [JsonProperty("DOGE")]
        public decimal Doge { get;private set;}
        [JsonProperty("DASH")]
        public decimal Dash { get;private set;}
        [JsonProperty("ETH")]
        public decimal Eth { get;private set;}
        [JsonProperty("WAVES")]
        public decimal Waves { get;private set;}
        [JsonProperty("ZEC")]
        public decimal Zec { get;private set;}
    }
    public class Reserved : IReserved
    {
        [JsonProperty("USD")]
        public decimal Usd { get;private set;}
        [JsonProperty("EUR")]
        public decimal Eur { get;private set;}
        [JsonProperty("RUB")]
        public decimal Rub { get;private set;}
        [JsonProperty("UAH")]
        public decimal Uah { get;private set;}
        [JsonProperty("BTC")]
        public decimal Btc { get;private set;}
        [JsonProperty("LTC")]
        public decimal Ltc { get;private set;}
        [JsonProperty("DOGE")]
        public decimal Doge { get;private set;}
        [JsonProperty("DASH")]
        public decimal Dash { get;private set;}
        [JsonProperty("ETH")]
        public decimal Eth { get;private set;}
        [JsonProperty("WAVES")]
        public decimal Waves { get;private set;}
        [JsonProperty("ZEC")]
        public decimal Zec { get;private set;}
    }
}