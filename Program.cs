using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
using System.Data;
using Newtonsoft.Json;
using PublicAPI;

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
            //var task = api.ApiQueryAsync("user_info", new Dictionary<string, string> ());
            //CUserInfo userInfo = JsonConvert.DeserializeObject<CUserInfo>(task.Result.ToString());

            //var task2 = api.ApiQueryAsync("user_open_orders", new Dictionary<string, string>());
            //CUserOpenOrders userOpenOrders = JsonConvert.DeserializeObject<CUserOpenOrders>(task2.Result.ToString());

            //Выбрать либо одну валютную пару, либо несколько (либо все)
            var task3 = api.ApiQueryAsync("trades", new Dictionary<string, string> (), "BTC_USD,BTC_EUR,BTC_RUB,BTC_UAH,DASH_BTC,DASH_USD,ETH_BTC,ETH_USD,DOGE_BTC,LTC_BTC,ETH_RUB,ETH_EUR,LTC_RUB,DASH_RUB,ETH_LTC,USD_RUB,WAVES_BTC");
            CMethodPublicAPI.CTradesResult tradesResult = JsonConvert.DeserializeObject<CMethodPublicAPI.CTradesResult>(task3.Result.ToString());          

            var task4 = api.ApiQueryAsync("order_book", new Dictionary<string, string>(), "BTC_USD,BTC_EUR,BTC_RUB,BTC_UAH,DASH_BTC,DASH_USD,ETH_BTC,ETH_USD,DOGE_BTC,LTC_BTC,ETH_RUB,ETH_EUR,LTC_RUB,DASH_RUB,ETH_LTC,USD_RUB,WAVES_BTC");
            CMethodPublicAPI.СOrder_booksResult orderBookResult = JsonConvert.DeserializeObject<CMethodPublicAPI.СOrder_booksResult>(task4.Result.ToString());

            var task5 = api.ApiQueryAsync("ticker", new Dictionary<string, string>());
            CMethodPublicAPI.CTickerResult tickerResult = JsonConvert.DeserializeObject<CMethodPublicAPI.CTickerResult>(task5.Result.ToString());

            var task6 = api.ApiQueryAsync("pair_settings", new Dictionary<string, string>());
            CMethodPublicAPI.CPair_settingsResult pair_settingsResult = JsonConvert.DeserializeObject<CMethodPublicAPI.CPair_settingsResult>(task6.Result.ToString());
            Console.ReadLine();


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
