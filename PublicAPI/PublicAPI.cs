using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PublicAPI
{
    public static class CPublicAPI
    {
        #region Список сделок по валютной паре
        public class CTradesBTCUSD
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesBTCEUR
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesBTCRUB
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesBTCUAH
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesDASHBTC
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesDASHUSD
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesETHBTC
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesETHUSD
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesDOGEBTC
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesLTCBTC
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesETHRUB
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesETHEUR
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesLTCRUB
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesDASHRUB
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesETHLTC
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesUSDRUB
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesWAVESBTC
        {
            public int trade_id { get; set; }
            public string type { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public decimal amount { get; set; }
            public int date { get; set; }
        }

        public class CTradesResult
        {
            public List<CTradesBTCUSD> BTC_USD { get; set; }
            public List<CTradesBTCEUR> BTC_EUR { get; set; }
            public List<CTradesBTCRUB> BTC_RUB { get; set; }
            public List<CTradesBTCUAH> BTC_UAH { get; set; }
            public List<CTradesDASHBTC> DASH_BTC { get; set; }
            public List<CTradesDASHUSD> DASH_USD { get; set; }
            public List<CTradesETHBTC> ETH_BTC { get; set; }
            public List<CTradesETHUSD> ETH_USD { get; set; }
            public List<CTradesDOGEBTC> DOGE_BTC { get; set; }
            public List<CTradesLTCBTC> LTC_BTC { get; set; }
            public List<CTradesETHRUB> ETH_RUB { get; set; }
            public List<CTradesETHEUR> ETH_EUR { get; set; }
            public List<CTradesLTCRUB> LTC_RUB { get; set; }
            public List<CTradesDASHRUB> DASH_RUB { get; set; }
            public List<CTradesETHLTC> ETH_LTC { get; set; }
            public List<CTradesUSDRUB> USD_RUB { get; set; }
            public List<CTradesWAVESBTC> WAVES_BTC { get; set; }
        }
        #endregion
        #region Книга ордеров по валютной паре
        public class СOrder_booksBTCUSD
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksBTCEUR
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksBTCRUB
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksBTCUAH
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksDASHBTC
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksDASHUSD
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksETHBTC
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksETHUSD
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksDOGEBTC
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksLTCBTC
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksETHRUB
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksETHEUR
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksLTCRUB
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksDASHRUB
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksETHLTC
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksUSDRUB
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksWAVESBTC
        {
            public decimal ask_quantity { get; set; }
            public decimal ask_amount { get; set; }
            public decimal ask_top { get; set; }
            public decimal bid_quantity { get; set; }
            public decimal bid_amount { get; set; }
            public decimal bid_top { get; set; }
            public List<List<decimal>> ask { get; set; }
            public List<List<decimal>> bid { get; set; }
        }

        public class СOrder_booksResult
        {
            public СOrder_booksBTCUSD BTC_USD { get; set; }
            public СOrder_booksBTCEUR BTC_EUR { get; set; }
            public СOrder_booksBTCRUB BTC_RUB { get; set; }
            public СOrder_booksBTCUAH BTC_UAH { get; set; }
            public СOrder_booksDASHBTC DASH_BTC { get; set; }
            public СOrder_booksDASHUSD DASH_USD { get; set; }
            public СOrder_booksETHBTC ETH_BTC { get; set; }
            public СOrder_booksETHUSD ETH_USD { get; set; }
            public СOrder_booksDOGEBTC DOGE_BTC { get; set; }
            public СOrder_booksLTCBTC LTC_BTC { get; set; }
            public СOrder_booksETHRUB ETH_RUB { get; set; }
            public СOrder_booksETHEUR ETH_EUR { get; set; }
            public СOrder_booksLTCRUB LTC_RUB { get; set; }
            public СOrder_booksDASHRUB DASH_RUB { get; set; }
            public СOrder_booksETHLTC ETH_LTC { get; set; }
            public СOrder_booksUSDRUB USD_RUB { get; set; }
            public СOrder_booksWAVESBTC WAVES_BTC { get; set; }
        }
        #endregion
        #region Cтатистика цен и объемов торгов по валютным парам
        public class CTickerBTCUSD
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerBTCEUR
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerBTCRUB
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerBTCUAH
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerDASHBTC
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerDASHUSD
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerETHBTC
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerETHUSD
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerDOGEBTC
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerLTCBTC
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerETHRUB
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerETHEUR
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerLTCRUB
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerDASHRUB
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerETHLTC
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerUSDRUB
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerWAVESBTC
        {
            public decimal buy_price { get; set; }
            public decimal sell_price { get; set; }
            public decimal last_trade { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal avg { get; set; }
            public decimal vol { get; set; }
            public decimal vol_curr { get; set; }
            public int updated { get; set; }
        }

        public class CTickerResult
        {
            public CTickerBTCUSD BTC_USD { get; set; }
            public CTickerBTCEUR BTC_EUR { get; set; }
            public CTickerBTCRUB BTC_RUB { get; set; }
            public CTickerBTCUAH BTC_UAH { get; set; }
            public CTickerDASHBTC DASH_BTC { get; set; }
            public CTickerDASHUSD DASH_USD { get; set; }
            public CTickerETHBTC ETH_BTC { get; set; }
            public CTickerETHUSD ETH_USD { get; set; }
            public CTickerDOGEBTC DOGE_BTC { get; set; }
            public CTickerLTCBTC LTC_BTC { get; set; }
            public CTickerETHRUB ETH_RUB { get; set; }
            public CTickerETHEUR ETH_EUR { get; set; }
            public CTickerLTCRUB LTC_RUB { get; set; }
            public CTickerDASHRUB DASH_RUB { get; set; }
            public CTickerETHLTC ETH_LTC { get; set; }
            public CTickerUSDRUB USD_RUB { get; set; }
            public CTickerWAVESBTC WAVES_BTC { get; set; }
        }
        #endregion
        #region Настройки валютных пар
        public class CPair_settingsBTCUSD
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsBTCEUR
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsBTCRUB
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsBTCUAH
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsDASHBTC
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsDASHUSD
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsETHBTC
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsETHUSD
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsDOGEBTC
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsLTCBTC
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsETHRUB
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsETHEUR
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsLTCRUB
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsDASHRUB
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsETHLTC
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsUSDRUB
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsWAVESBTC
        {
            public decimal min_quantity { get; set; }
            public decimal max_quantity { get; set; }
            public decimal min_price { get; set; }
            public decimal max_price { get; set; }
            public decimal max_amount { get; set; }
            public decimal min_amount { get; set; }
        }

        public class CPair_settingsResult
        {
            public CPair_settingsBTCUSD BTC_USD { get; set; }
            public CPair_settingsBTCEUR BTC_EUR { get; set; }
            public CPair_settingsBTCRUB BTC_RUB { get; set; }
            public CPair_settingsBTCUAH BTC_UAH { get; set; }
            public CPair_settingsDASHBTC DASH_BTC { get; set; }
            public CPair_settingsDASHUSD DASH_USD { get; set; }
            public CPair_settingsETHBTC ETH_BTC { get; set; }
            public CPair_settingsETHUSD ETH_USD { get; set; }
            public CPair_settingsDOGEBTC DOGE_BTC { get; set; }
            public CPair_settingsLTCBTC LTC_BTC { get; set; }
            public CPair_settingsETHRUB ETH_RUB { get; set; }
            public CPair_settingsETHEUR ETH_EUR { get; set; }
            public CPair_settingsLTCRUB LTC_RUB { get; set; }
            public CPair_settingsDASHRUB DASH_RUB { get; set; }
            public CPair_settingsETHLTC ETH_LTC { get; set; }
            public CPair_settingsUSDRUB USD_RUB { get; set; }
            public CPair_settingsWAVESBTC WAVES_BTC { get; set; }
        }
        #endregion//
    }
}
