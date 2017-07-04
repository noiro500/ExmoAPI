using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PublicAPI
{
    public static class CPublicApi
    {
        #region Список сделок по валютной паре
        public class CTradesBtcusd
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesBtceur
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesBtcrub
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesBtcuah
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesDashbtc
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesDashusd
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesEthbtc
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesEthusd
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesDogebtc
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesLtcbtc
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesEthrub
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesEtheur
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesLtcrub
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesDashrub
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesEthltc
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesUsdrub
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesWavesbtc
        {
            public int Trade_Id { get; set; }
            public string Type { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Amount { get; set; }
            public int Date { get; set; }
        }

        public class CTradesResult
        {
            public List<CTradesBtcusd> Btc_Usd { get; set; }
            public List<CTradesBtceur> Btc_Eur { get; set; }
            public List<CTradesBtcrub> Btc_Rub { get; set; }
            public List<CTradesBtcuah> Btc_Uah { get; set; }
            public List<CTradesDashbtc> Dash_Btc { get; set; }
            public List<CTradesDashusd> Dash_Usd { get; set; }
            public List<CTradesEthbtc> Eth_Btc { get; set; }
            public List<CTradesEthusd> Eth_Usd { get; set; }
            public List<CTradesDogebtc> Doge_Btc { get; set; }
            public List<CTradesLtcbtc> Ltc_Btc { get; set; }
            public List<CTradesEthrub> Eth_Rub { get; set; }
            public List<CTradesEtheur> Eth_Eur { get; set; }
            public List<CTradesLtcrub> Ltc_Rub { get; set; }
            public List<CTradesDashrub> Dash_Rub { get; set; }
            public List<CTradesEthltc> Eth_Ltc { get; set; }
            public List<CTradesUsdrub> Usd_Rub { get; set; }
            public List<CTradesWavesbtc> Waves_Btc { get; set; }
        }
        #endregion
        #region Книга ордеров по валютной паре
        public class СOrderBooksBtcusd
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksBtceur
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksBtcrub
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksBtcuah
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksDashbtc
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksDashusd
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksEthbtc
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksEthusd
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksDogebtc
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksLtcbtc
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksEthrub
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksEtheur
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksLtcrub
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksDashrub
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksEthltc
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksUsdrub
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksWavesbtc
        {
            public decimal Ask_Quantity { get; set; }
            public decimal Ask_Amount { get; set; }
            public decimal Ask_Top { get; set; }
            public decimal Bid_Quantity { get; set; }
            public decimal Bid_Amount { get; set; }
            public decimal Bid_Top { get; set; }
            public List<List<decimal>> Ask { get; set; }
            public List<List<decimal>> Bid { get; set; }
        }

        public class СOrderBooksResult
        {
            
            public СOrderBooksBtcusd Btc_Usd { get; set; }
            public СOrderBooksBtceur Btc_Eur { get; set; }
            public СOrderBooksBtcrub Btc_Rub { get; set; }
            public СOrderBooksBtcuah Btc_Uah { get; set; }
            public СOrderBooksDashbtc Dash_Btc { get; set; }
            public СOrderBooksDashusd Dash_Usd { get; set; }
            public СOrderBooksEthbtc Eth_Btc { get; set; }
            public СOrderBooksEthusd Eth_Usd { get; set; }
            public СOrderBooksDogebtc Doge_Btc { get; set; }
            public СOrderBooksLtcbtc Ltc_Btc { get; set; }
            public СOrderBooksEthrub Eth_Rub { get; set; }
            public СOrderBooksEtheur Eth_Eur { get; set; }
            public СOrderBooksLtcrub Ltc_Rub { get; set; }
            public СOrderBooksDashrub Dash_Rub { get; set; }
            public СOrderBooksEthltc Eth_Ltc { get; set; }
            public СOrderBooksUsdrub Usd_Rub { get; set; }
            public СOrderBooksWavesbtc Waves_Btc { get; set; }
        }
        #endregion
        #region Cтатистика цен и объемов торгов по валютным парам
        public class CTickerBtcusd
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerBtceur
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerBtcrub
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerBtcuah
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerDashbtc
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerDashusd
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerEthbtc
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerEthusd
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerDogebtc
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerLtcbtc
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerEthrub
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerEtheur
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerLtcrub
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerDashrub
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerEthltc
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerUsdrub
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerWavesbtc
        {
            public decimal Buy_Price { get; set; }
            public decimal Sell_Price { get; set; }
            public decimal Last_Trade { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Avg { get; set; }
            public decimal Vol { get; set; }
            public decimal Vol_Curr { get; set; }
            public int Updated { get; set; }
        }

        public class CTickerResult
        {
            
            public CTickerBtcusd Btc_Usd { get; set; }
            
            public CTickerBtceur Btc_Eur { get; set; }
            
            public CTickerBtcrub Btc_Rub { get; set; }
            
            public CTickerBtcuah Btc_Uah { get; set; }
            
            public CTickerDashbtc Dash_Btc { get; set; }
            
            public CTickerDashusd Dash_Usd { get; set; }
            
            public CTickerEthbtc Eth_Btc { get; set; }
           
            public CTickerEthusd Eth_Usd { get; set; }
            
            public CTickerDogebtc Doge_Btc { get; set; }
            
            public CTickerLtcbtc Ltc_Btc { get; set; }
            
            public CTickerEthrub Eth_Rub { get; set; }
            
            public CTickerEtheur Eth_Eur { get; set; }
            
            public CTickerLtcrub Ltc_Rub { get; set; }
            
            public CTickerDashrub Dash_Rub { get; set; }
            
            public CTickerEthltc Eth_Ltc { get; set; }
            
            public CTickerUsdrub Usd_Rub { get; set; }
            
            public CTickerWavesbtc Waves_Btc { get; set; }
        }
        #endregion
        #region Настройки валютных пар
        public class CPairSettingsBtcusd
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsBtceur
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsBtcrub
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsBtcuah
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsDashbtc
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsDashusd
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsEthbtc
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsEthusd
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsDogebtc
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsLtcbtc
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsEthrub
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsEtheur
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsLtcrub
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsDashrub
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsEthltc
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsUsdrub
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsWavesbtc
        {
            public decimal Min_Quantity { get; set; }
            public decimal Max_Quantity { get; set; }
            public decimal Min_Price { get; set; }
            public decimal Max_Price { get; set; }
            public decimal Max_Amount { get; set; }
            public decimal Min_Amount { get; set; }
        }

        public class CPairSettingsResult
        {
            public CPairSettingsBtcusd Btc_Usd { get; set; }
            public CPairSettingsBtceur Btc_Eur { get; set; }
            public CPairSettingsBtcrub Btc_Rub { get; set; }
            public CPairSettingsBtcuah Btc_Uah { get; set; }
            public CPairSettingsDashbtc Dash_Btc { get; set; }
            public CPairSettingsDashusd Dash_Usd { get; set; }
            public CPairSettingsEthbtc Eth_Btc { get; set; }
            public CPairSettingsEthusd Eth_Usd { get; set; }
            public CPairSettingsDogebtc Doge_Btc { get; set; }
            public CPairSettingsLtcbtc Ltc_Btc { get; set; }
            public CPairSettingsEthrub Eth_Rub { get; set; }
            public CPairSettingsEtheur Eth_Eur { get; set; }
            public CPairSettingsLtcrub Ltc_Rub { get; set; }
            public CPairSettingsDashrub Dash_Rub { get; set; }
            public CPairSettingsEthltc Eth_Ltc { get; set; }
            public CPairSettingsUsdrub Usd_Rub { get; set; }
            public CPairSettingsWavesbtc Waves_Btc { get; set; }
        }
        #endregion//
    }
}
