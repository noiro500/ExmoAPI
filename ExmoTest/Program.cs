using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ExmoAPI.Authenticated_API.Classes;
using ExmoAPI.Generic;
using ExmoAPI.Public_API.Classes;
using System.Linq;

#pragma warning disable 1587

namespace ExmoTest
{
    class Program
    {
        static void Main(string[] args)
        {

            /***********************/
            /********Example********/
            /***********************/

            string apiName;
            var api = new ExmoApi("", "");
            string tradeCouples = "LTC_RUB";
            int? limit = 1000;

            /*Public API*/
            
            ///<summary>trades
            /// <remarks>Список сделок по валютной паре</remarks>
            /// <param name="tradeCouples">одна или несколько валютных пар разделенных запятой (пример BTC_USD,BTC_EUR)</param>
            /// <param name="limit">кол-во отображаемых позиций (по умолчанию 100, максимум 1000)</param>
            ///<returns>ResultList type=CTrade ></returns>
            /// </summary>
            IHelperPublicAPI<CTrade> testTradesApi=new CHelperPublicAPI<CTrade>();
            Task testTradesApiResult= testTradesApi.GetResultAsync("trades", api, tradeCouples, limit);
            testTradesApiResult.Wait();
            Console.WriteLine($"Список сделок по валютной паре {tradeCouples}:");

            /*foreach (var tmp in testTradesApi.ResultList)
            {
                Console.WriteLine($"{tmp.TradeId} {tmp.Type} {tmp.Price} {tmp.Quantity} {tmp.Amount} {(new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(tmp.Date)}");
            }*/
            using (StreamWriter text = new StreamWriter(@"C:\tmp\test", false))
            {
                
                /*foreach (var tmp in testTradesApi.ResultList.Reverse())
                {
                    text.WriteLine(tmp.Price);
                    // $"{tmp.Price};{tmp.Date}");
                }*/
                decimal openPrice, minPrace, maxPrice, closePrice;
                int j = 0;
                int t = 1;
                List<decimal> tempList=new List<decimal>();
                foreach (var i in testTradesApi.ResultList.Reverse())
                {
                    if (j < 10)
                    {
                        tempList.Add(i.Price);
                        j++;
                        continue;
                    }
                    else
                    {
                        openPrice = tempList[0];
                        minPrace = tempList.Min();
                        maxPrice = tempList.Max();
                        closePrice = tempList[tempList.Count-1];
                        text.WriteLine($"{t};{openPrice};{minPrace};{maxPrice};{closePrice}");
                        tempList.Clear();
                        t++;
                        j = 0;
                    }
                }                
            }

            ///<summary>order_book
            /// <remarks>Книга ордеров по валютной паре</remarks>
            /// <param name="tradeCouples">одна или несколько валютных пар разделенных запятой (пример BTC_USD,BTC_EUR)</param>
            /// <param name="limit">кол-во отображаемых позиций (по умолчанию 100, максимум 1000)</param>
            ///<returns>Result type=COrderBook></returns>
            /// </summary>
            IHelperPublicAPI<COrderBook> testOrderBookApi = new CHelperPublicAPI<COrderBook>();
            Task testOrderBookApiTask=  testOrderBookApi.GetResultAsync("order_book", api, tradeCouples, limit);
            testOrderBookApiTask.Wait();
            Console.WriteLine("\nКнига ордеров по валютной паре:");
            Console.WriteLine($"{testOrderBookApi.ResultMetod.AskQuantity} {testOrderBookApi.ResultMetod.AskAmount} {testOrderBookApi.ResultMetod.AskTop}, {testOrderBookApi.ResultMetod.BidQuantity}, " +
                              $"{testOrderBookApi.ResultMetod.BidAmount}, {testOrderBookApi.ResultMetod.BidTop}");
            Console.WriteLine("\nСписок ордеров на покупку:");
            foreach (var i in testOrderBookApi.ResultMetod.Ask)
            {
                Console.WriteLine($"{i[0]}, {i[1]}, {i[2]}");
            }
            Console.WriteLine("\nСписок ордеров на продажу:");
            foreach (var i in testOrderBookApi.ResultMetod.Bid)
            {
                Console.WriteLine($"{i[0]}, {i[1]}, {i[2]}");
            }
            
            ///<summary>ticker
            /// <remarks>Cтатистика цен и объемов торгов по валютным парам</remarks>
            ///<returns>Result type=CTicker</returns>
            /// </summary>
            IHelperPublicAPI<CTicker> testTickerApi=new CHelperPublicAPI<CTicker>();
            Task testTickerApiTask = testTickerApi.GetResultAsync("ticker", api, tradeCouples);
            testTickerApiTask.Wait();
            Console.WriteLine($"\nCтатистика цен и объемов торгов по валютной паре {tradeCouples}:");
            Console.WriteLine($"{testTickerApi.ResultMetod.High}, {testTickerApi.ResultMetod.Low}, {testTickerApi.ResultMetod.Avg}, " +
                              $"{testTickerApi.ResultMetod.Vol}, {testTickerApi.ResultMetod.VolCurr}, {testTickerApi.ResultMetod.LastTrade}, " +
                              $"{testTickerApi.ResultMetod.BuyPrice}, {testTickerApi.ResultMetod.SellPrice}, " +
                              $"{(new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(testTickerApi.ResultMetod.Updated)}");

            ///<summary>pair_settings
            /// <remarks>Настройки валютных пар</remarks>
            /// <param name="tradeCouples">одна или несколько валютных пар разделенных запятой (пример BTC_USD,BTC_EUR)</param>
            ///<returns>Result type=CPairSettings></returns>
            /// </summary>
            IHelperPublicAPI<CPairSettings> testPairSettingApi=new CHelperPublicAPI<CPairSettings>();
            Task testPairSettingApiTask = testPairSettingApi.GetResultAsync("pair_settings", api, tradeCouples);
            testPairSettingApiTask.Wait();
            Console.WriteLine($"\nНастройки валютной пары {tradeCouples}:");
            Console.WriteLine($"{testPairSettingApi.ResultMetod.MinQuantity}, {testPairSettingApi.ResultMetod.MaxQuantity} " +
                              $"{testPairSettingApi.ResultMetod.MinPrice}, {testPairSettingApi.ResultMetod.MaxPrice}, " +
                              $"{testPairSettingApi.ResultMetod.MinAmount}, {testPairSettingApi.ResultMetod.MaxAmount}");

            ///<summary>currency
            /// <remarks>Cписок валют биржи</remarks>
            ///<returns>Result type=IList<string>></returns>
            /// </summary>
            Task currencyTask = CCurrency.GetCurrencyAsync(api);
            currencyTask.Wait();
            Console.WriteLine("\nCписок валют биржи:");
            foreach (var i in CCurrency.CurrencyList)
            {
                Console.WriteLine(i);
            }

            //<summary>currencyPair
            /// <remarks>Cписок валютных пар (не входит в ExmoApi)</remarks>
            ///<returns>Result type=IList<string>></returns>
            /// </summary>
            Task currencyPairTaskTask = CCurrency.GetCurrencyPairListAsync(api);
            currencyPairTaskTask.Wait();
            Console.WriteLine("\nCписок валютных пар биржи:");
            foreach (var i in CCurrency.CurrencyPairList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        
    }
}
