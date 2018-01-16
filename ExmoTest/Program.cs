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







            #region Authenticated_API
            /*
            #region user_info

            var jsonUserInfo = api.ApiQueryAsync("user_info", new Dictionary<string, string>());
            var objUserInfo = JObject.Parse(jsonUserInfo.Result.ToString());
            var objArrayUserInfo = JsonConvert.DeserializeObject<CUserInfo>(objUserInfo.ToString());

            #endregion

            #region order_create

            
            var pair = currentPair;
            var quantity = 0.17;
            var price = 2800;
            var type = "sell";
            var jsonOrderCreate = api.ApiQueryAsync("order_create",
                new Dictionary<string, string>()
                {
                    {"pair", pair},
                    {"quantity", quantity.ToString(CultureInfo.InvariantCulture)},
                    {"price", price.ToString(CultureInfo.InvariantCulture)},
                    {"type", type}
                });

            var objOrderCreate = JObject.Parse(jsonOrderCreate.Result.ToString());
            var objArrayOrderCreate = JsonConvert.DeserializeObject<COrderCreate>(objOrderCreate.ToString());
            

            #endregion

            #region order_cancel

            
            var jsonOrderCancel = api.ApiQueryAsync("order_cancel",
                new Dictionary<string, string>()
                {
                    {"order_id", objArrayOrderCreate.OrderId.ToString(CultureInfo.InvariantCulture)}
                });
            var objOrderCansel = JObject.Parse(jsonOrderCancel.Result.ToString());
            var objArrayOrderCansel = JsonConvert.DeserializeObject<COrderCancel>(objOrderCansel.ToString());
            

            #endregion

            #region user_open_orders




            var jsonUserOpenOrders = api.ApiQueryAsync("user_open_orders", new Dictionary<string, string>());
            var objUserOpenOrders = JObject.Parse(jsonUserOpenOrders.Result.ToString());
            CUserOpenOrders[] objArrayUserOpenOrders;

            foreach (var c in CCurrency.GetCurrencyPairList(api))
            {
                if (objUserOpenOrders.ToString().Contains(c))
                {
                    objArrayUserOpenOrders =
                        JsonConvert.DeserializeObject<CUserOpenOrders[]>(objUserOpenOrders[c].ToString());
                    
                    foreach (var f in objArrayUserOpenOrders)
                    {
                        Console.WriteLine(" " + c);
                        Console.WriteLine(f.OrderId.ToString(CultureInfo.InvariantCulture));
                        Console.WriteLine(
                            (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(Convert.ToDouble(f.Created)));
                        Console.WriteLine(f.Type.ToString(CultureInfo.InvariantCulture));
                        Console.WriteLine(f.Pair.ToString(CultureInfo.InvariantCulture));
                        Console.WriteLine(f.Price.ToString(CultureInfo.InvariantCulture));
                        Console.WriteLine(f.Quantity.ToString(CultureInfo.InvariantCulture));
                        Console.WriteLine(f.Amount.ToString(CultureInfo.InvariantCulture));
                    }
                }
            }

            #endregion

            #region user_trades

            var pair = "BTC_RUB";
            var limit = 10;
            var offcet = 0;
            var jsonUserTrades = api.ApiQueryAsync("user_trades",
                new Dictionary<string, string>()
                {
                    {"pair", pair},
                    {"limit", limit.ToString(CultureInfo.InvariantCulture)},
                    {"offcet", offcet.ToString(CultureInfo.InvariantCulture)}
                });
            var objUserTrades = JObject.Parse(jsonUserTrades.Result.ToString());
            var objArrayUserTrades = JsonConvert.DeserializeObject<CUserTrades[]>(objUserTrades[pair].ToString());
//Сделать как с user_open_orders

            #endregion

            #region user_cancelled_orders

            var jsonUserCancelledOrders = api.ApiQueryAsync("user_cancelled_orders",
                new Dictionary<string, string>()
                {
                    {"limit", 10.ToString(CultureInfo.InvariantCulture)},
                    {"offcet", 0.ToString(CultureInfo.InvariantCulture)}
                });
            var objUserCancelledOrders = JArray.Parse(jsonUserCancelledOrders.Result.ToString());
            var objArrayUserCancelledOrders =
                JsonConvert.DeserializeObject<CUserCancelledOrders[]>(objUserCancelledOrders.ToString());

            #endregion

            #region order_trades

            var orderId = objArrayUserTrades[0].OrderId;
            var jsonOrderTrades = api.ApiQueryAsync("order_trades",
                new Dictionary<string, string>()
                {
                    {"order_id", orderId.ToString(CultureInfo.InvariantCulture)}
                });
            var objOrderTrades = JObject.Parse(jsonOrderTrades.Result.ToString());
            var objArrayOrderTrades = JsonConvert.DeserializeObject<COrderTrades>(objOrderTrades.ToString());

            #endregion

            #region required_amount

            pair = "USD_RUB";
            var quant = 7;
            var jsonRequiredAmount = api.ApiQueryAsync("required_amount",
                new Dictionary<string, string>()
                {
                    {"pair", pair},
                    {"quantity", quant.ToString(CultureInfo.InvariantCulture)}
                });
            var objRequiredAmount = JObject.Parse(jsonRequiredAmount.Result.ToString());
            var objArrayRequiredAmount = JsonConvert.DeserializeObject<CRequiredAmount>(objRequiredAmount.ToString());

            #endregion
            */
            #endregion

            //IHelperAuthAPI<CRequiredAmount> test=new CHelperAuthAPI<CRequiredAmount>();
            //test.GetResult("required_amount", api,
            //    new Dictionary<string, string>()
            //    {
            //        {"pair", currentPair},
            //        {"quantity", 7.ToString(CultureInfo.InvariantCulture)}
            //    });
            //var a = test.Result;

            //IHelperPublicAPI<CTrades> uuu=new CHelperPublicAPI<CTrades>();
            //var ggg = uuu.GetResult("trades", api, currentPair);

            /*IHelperPublicAPI<CTrades> ttt=new CHelperPublicAPI<CTrades>();
            
            Task  eResult = ttt.GetResult("trades", currentPair, api);
            eResult.Wait();
            foreach (var e in ttt.ResultList)
            {
                Console.WriteLine(e.Price);
            }*/

            /***********************/
            /********Example********/
            /***********************/

            string apiName;
            var api = new ExmoApi("", "");
            string tradeCouples = "ETC_USD";
            int? limit = 6000;

            /*Public API*/
            
            ///<summary>trades
            /// <remarks>Список сделок по валютной паре</remarks>
            /// <param name="tradeCouples">одна или несколько валютных пар разделенных запятой (пример BTC_USD,BTC_EUR)</param>
            /// <param name="limit">кол-во отображаемых позиций (по умолчанию 100, максимум 1000)</param>
            ///<returns>ResultList type=CTrade ></returns>
            /// </summary>
            IHelperPublicAPI<CTrades> testTradesApi=new CHelperPublicAPI<CTrades>();
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
                ulong firstTime = testTradesApi.ResultList[(testTradesApi.ResultList).Count - 1].Date;
                ulong lastTime = testTradesApi.ResultList[0].Date;
                Console.WriteLine($"1000 результатов берется за {lastTime-firstTime}");
                /*foreach (var i in testTradesApi.ResultList.Reverse())
                {
                    if (j < 54)
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
                    
                    
                }  */    
                text.Close();
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
            using (StreamWriter text = new StreamWriter(@"C:\tmp\test", false))
            {
                foreach (var i in testOrderBookApi.ResultMetod.Bid)
                {
                    Console.WriteLine($"{i[0]}, {i[1]}, {i[2]}");
                }
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
