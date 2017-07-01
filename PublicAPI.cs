using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmoAPI
{
    static class PublicAPI
    {

        public class CBtcUsd
        {
            public string ask_quantity { get; set; }
            public string ask_amount { get; set; }
            public string ask_top { get; set; }
            public string bid_quantity { get; set; }
            public string bid_amount { get; set; }
            public string bid_top { get; set; }
            //public List<List<int>> ask { get; set; }
            //public List<List<int>> bid { get; set; }
        }

        public class RootObject
        {
            public CBtcUsd Btc_Usd { get; set; }
        }
    }
}
