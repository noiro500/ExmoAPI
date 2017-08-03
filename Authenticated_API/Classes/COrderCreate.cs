using System;
using ExmoAPI.Authenticated_API.Interfeces;
using Newtonsoft.Json;

namespace ExmoAPI.Authenticated_API.Classes
{
    //Создание ордера
    public class COrderCreate : IOrderCreate
    {
        [JsonProperty("result")]
        public bool Result { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("order_id")]
        public decimal OrderId { get; set; }
    }
}