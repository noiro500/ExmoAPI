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
        public T Result { get; private set; } = default(T);

        private async Task<IList<T>> GetResultList(string method, ExmoApi api, string currentPair)
        {
            var jsonQuery = await api.ApiQueryAsync(method, new Dictionary<string, string>(), currentPair);
            //var objQuery = JObject.Parse(jsonQuery.Result.ToString());
            var objQuery = JObject.Parse(jsonQuery.ToString());
            var objResult = JsonConvert.DeserializeObject<T[]>(objQuery[currentPair].ToString());
            return ResultList =objResult.ToList();
        }

        public async Task<T> GetResult(string method, ExmoApi api, string currentPair)
        {
            if (method == "trades")
            {
                //ResultList = await GetResultList(method, api, currentPair);
                Task resulTask = GetResultList(method, api, currentPair);
                resulTask.Wait();
                return default(T);
            }
            var jsonQuery = await api.ApiQueryAsync(method, new Dictionary<string, string>(), currentPair);
            var objQuery = JObject.Parse(jsonQuery.ToString());
            var objResult = JsonConvert.DeserializeObject<T>(objQuery[currentPair].ToString());
            return Result = objResult;

        }
    }

    public class CHelperAuthAPI<T> : IHelperAuthAPI<T>
    {
        public IList<T> ResultList { get; private set; } = null;

        public T Result { get; private set; } = default(T);

        private async Task<IList<T>> GetResultList(string method, ExmoApi api, Dictionary<string, string> dic, string currentPair)
        {
            var jsonQuery = await api.ApiQueryAsync(method, dic);
            if (method == "user_cancelled_orders")
            {
                var objQueryArray = JArray.Parse(jsonQuery.ToString());
                var objResultArray = JsonConvert.DeserializeObject<T[]>(objQueryArray.ToString());
                return ResultList = objResultArray.ToList();
            }
            var objQuery = JObject.Parse(jsonQuery.ToString());
            var objResult = JsonConvert.DeserializeObject<T[]>(objQuery[currentPair].ToString());
            return ResultList = objResult.ToList();
        }

        public async Task<T> GetResult(string method, ExmoApi api, Dictionary<string, string> dic = null, string currentPair = null)
        {
            if (dic == null)
                dic=new Dictionary<string, string>();
            if (method == "user_open_orders" || method == "user_trades" || method == "user_cancelled_orders")
            {
                await GetResultList(method, api, dic, currentPair);
                return Result; 
            }
            var jsonQuery = await api.ApiQueryAsync(method, dic);
            var objQuery = JObject.Parse(jsonQuery.ToString());
            var objResult = JsonConvert.DeserializeObject<T>(objQuery.ToString());
            return Result = objResult;
        }
    }
}