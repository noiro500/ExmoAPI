﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ExmoAPI;
using ExmoAPI.Authenticated_API.Classes;
using ExmoAPI.Generic;
using ExmoAPI.Public_API.Classes;
using ExmoAPI.Public_API.Interfaces;

#pragma warning disable 1587

namespace ExmoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new ExmoApi("", "");
            string tradeCouples = "LTC_RUB";






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

            /*Public API*/


            ///<summary>trades
            /// <remarks>Список сделок по валютной паре</remarks>
            /// <param name="tradeCouples">одна или несколько валютных пар разделенных запятой (пример BTC_USD,BTC_EUR)</param>
            /// <param name="limit">кол-во отображаемых позиций (по умолчанию 100, максимум 1000)</param>
            ///<returns>ResultList type=IList</returns>
            /// </summary>
            IHelperPublicAPI<CTrade> testTradesApi=new CHelperPublicAPI<CTrade>();
            testTradesApi.GetResult("trades", api, tradeCouples, 2);
            
            foreach (var tmp in testTradesApi.ResultList)
            {
                Console.WriteLine($"{tmp.TradeId} {tmp.Type} {tmp.Price} {tmp.Quantity} {tmp.Amount} {(new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(tmp.Date)}");
            }

            ///<summary>order_book
            /// <remarks>Книга ордеров по валютной паре</remarks>
            /// <param name="pair">одна или несколько валютных пар разделенных запятой (пример BTC_USD,BTC_EUR)</param>
            /// <param name="limit">кол-во отображаемых позиций (по умолчанию 100, максимум 1000)</param>
            ///<returns>ResultList type=IList</returns>
            /// </summary>
            IHelperPublicAPI<COrderBook> testOrderBookApi=new CHelperPublicAPI<COrderBook>();
            var a =testOrderBookApi.GetResult("order_book", api, tradeCouples, 10);
            
            Console.WriteLine("Книга ордеров по валютной паре:");
            Console.WriteLine($"{a.Result.AskQuantity} {a.Result.AskAmount} {a.Result.AskTop}, {a.Result.BidQuantity}," +
                              $"{testOrderBookApi.Result.BidAmount}, {testOrderBookApi.Result.BidTop}");
            Console.WriteLine("Список ордеров на покупку:");
            foreach (var i in testOrderBookApi.Result.Ask)
            {
                Console.WriteLine($"{i[0]}, {i[1]}, {i[2]}");
            }
            Console.WriteLine("Список ордеров на продажу:");
            foreach (var i in testOrderBookApi.Result.Bid)
            {
                Console.WriteLine($"{i[0]}, {i[1]}, {i[2]}");
            }

            Console.ReadLine();

        }
        
    }
}
