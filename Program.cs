using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
namespace ExmoAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init
            var api = new ExmoApi("K-aef06338eb8ee1794b6cdcde33e53e90d8d4578f", "S-0e84d7277cc01495d3452c5ca23635e24962b2e6");

            //sync query
            /*var result = api.ApiQuery("user_info", new Dictionary<string, string>());
            Console.WriteLine("sync result");
            Console.WriteLine(result);
            var result2 = api.ApiQuery("user_cancelled_orders", new Dictionary<string, string> { { "limit", "100" }, { "offset", "0"} });
            Console.WriteLine("sync result2");
            Console.WriteLine(result2);*/


            //async query
            //Запрос информация о пользователе
            var task = api.ApiQueryAsync("user_info", new Dictionary<string, string> ());
            CUserInfo userInfo = JsonConvert.DeserializeObject<CUserInfo>(task.Result.ToString());

            var task2 = api.ApiQueryAsync("user_open_orders", new Dictionary<string, string>());
            CUserOpenOrders userOpenOrders = JsonConvert.DeserializeObject<CUserOpenOrders>(task2.Result.ToString());

            
            var task3 = api.PubApiQueryAsync("trades", new Dictionary<string, string>(), "BTC_USD");
            PublicAPI.RootObject _BTCUSD = JsonConvert.DeserializeObject<PublicAPI.RootObject>(task3.Result.ToString());
            

            Console.ReadLine();
            Console.WriteLine(task3.Result.ToString());

           

            //Task.Factory.StartNew(async () =>
            //{
            //    var result3 = await api.ApiQueryAsync("user_cancelled_orders", new Dictionary<string, string> { { "limit", "2" }, { "offset", "0" } });
            //    //Console.WriteLine("async result4");
            //    //Console.WriteLine(result3);
            //});

            //Console.ReadLine();
        }
    }
}
