using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ExmoAPI
{

    public class BTCUSD
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class BTCEUR
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class BTCRUB
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class BTCUAH
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class DASHBTC
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class DASHUSD
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class ETHBTC
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class ETHUSD
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class ETHRUB
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class ETHEUR
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class DOGEBTC
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class LTCBTC
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class LTCRUB
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class DASHRUB
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class ETHLTC
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class USDRUB
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class WAVESBTC
    {
        public string order_id { get; set; }
        public string created { get; set; }
        public string type { get; set; }
        public string pair { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }
    }

    public class CUserOpenOrders
    {
        public List<BTCUSD> BTC_USD { get; set; }
        public List<BTCEUR> BTC_EUR { get; set; }
        public List<BTCRUB> BTC_RUB { get; set; }
        public List<BTCUAH> BTC_UAH { get; set; }
        public List<DASHBTC> DASH_BTC { get; set; }
        public List<DASHUSD> DASH_USD { get; set; }
        public List<ETHBTC> ETH_BTC { get; set; }
        public List<ETHUSD> ETH_USD { get; set; }
        public List<ETHRUB> ETH_RUB { get; set; }
        public List<ETHEUR> ETH_EUR { get; set; }
        public List<DOGEBTC> DOGE_BTC { get; set; }
        public List<LTCBTC> LTC_BTC { get; set; }
        public List<LTCRUB> LTC_RUB { get; set; }
        public List<DASHRUB> DASH_RUB { get; set; }
        public List<ETHLTC> ETH_LTC { get; set; }
        public List<USDRUB> USD_RUB { get; set; }
        public List<WAVESBTC> WAVES_BTC { get; set; }

    }
}
