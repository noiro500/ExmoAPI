using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExmoAPI.Generic
{
    public class CHelperPublicAPI<T> : IHelperPublicAPI<T>
    {
        public IList<T> ResultList { get; private set; } = null;
        public T ResultMetod { get; private set; } = default(T);

        public async Task GetResultAsync(string method, ExmoApi api=null, string tradeCouples="BTC_USD", int? limit = null)
        {
            api = api ?? (new ExmoApi("", ""));
            var jsonQuery = await api.ApiQueryAsync(method, new Dictionary<string, string>(), tradeCouples, limit);
            var objQuery = JObject.Parse(jsonQuery.ToString());
            if (method == "trades")
                ResultList = (JsonConvert.DeserializeObject<T[]>(objQuery[tradeCouples].ToString())).ToList();
            
            else
                ResultMetod = JsonConvert.DeserializeObject<T>(objQuery[tradeCouples].ToString());
                
        }
    }

    public class CHelperAuthAPI<T> : IHelperAuthAPI<T>
    {
        public IList<T> ResultList { get; private set; } = null;

        public T ResultMetod { get; private set; } = default(T);

        /*private async Task GetResultList(string method, ExmoApi api, Dictionary<string, string> dic, string tradeCouples)
        {
            var jsonQuery = await api.ApiQueryAsync(method, dic);
            if (method == "user_cancelled_orders")
            {
                var objQueryArray = JArray.Parse(jsonQuery.ToString());
                var objResultArray = JsonConvert.DeserializeObject<T[]>(objQueryArray.ToString());
                ResultList = objResultArray.ToList();
            }
            var objQuery = JObject.Parse(jsonQuery.ToString());
            var objResult = JsonConvert.DeserializeObject<T[]>(objQuery[tradeCouples].ToString());
            ResultList = objResult.ToList();
        }*/

        public async Task GetResultAsync(string method, ExmoApi api, Dictionary<string, string> dic = null, string tradeCouples = "BTC_USD")
        {
            if (dic == null)
                dic=new Dictionary<string, string>();
            var jsonQuery = await api.ApiQueryAsync(method, dic);
            var objQuery = JObject.Parse(jsonQuery.ToString());
            if (method == "user_cancelled_orders")
            {
                ResultList = JsonConvert.DeserializeObject<T[]>(objQuery.ToString());
                //ResultList = objResultArray.ToList();
            }
            if (method == "user_open_orders" || method == "user_trades" /*|| method == "user_cancelled_orders"*/)
            {
                ResultList = JsonConvert.DeserializeObject<T[]>(objQuery[tradeCouples].ToString());
                //ResultList = objResult.ToList();
                //await GetResultList(method, api, dic, tradeCouples);
                //return ResultMetod; 
            }
            else
            {
                //var jsonQuery = await api.ApiQueryAsync(method, dic);
                //var objQuery = JObject.Parse(jsonQuery.ToString());
                ResultMetod = JsonConvert.DeserializeObject<T>(objQuery.ToString());
                //ResultMetod = objResult;
            }
        }
    }
}