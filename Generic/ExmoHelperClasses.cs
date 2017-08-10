using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExmoAPI.Generic
{
    public class CHelperPublicAPI<T> : IHelperPublicAPI<T>
    {
        public IList<T> ResultList { get; private set; }
        public T Result { get; private set; }

        private IList<T> GetResultTradesList(string method, ExmoApi api, string currentPair)
        {
            var jsonQuery = api.ApiQueryAsync(method, new Dictionary<string, string>(), currentPair);
            var objQuery = JObject.Parse(jsonQuery.Result.ToString());
            var objResult = JsonConvert.DeserializeObject<T[]>(objQuery[currentPair].ToString());
            return ResultList = objResult.ToList();
        }

        public T GetResult(string method, ExmoApi api, string currentPair)
        {
            if (method == "trades")
            {
                GetResultTradesList(method, api, currentPair);
                return Result;
            }
            var jsonQuery = api.ApiQueryAsync(method, new Dictionary<string, string>(), currentPair);
            var objQuery = JObject.Parse(jsonQuery.Result.ToString());
            var objResult = JsonConvert.DeserializeObject<T>(objQuery[currentPair].ToString());
            return Result = objResult;

        }
    }

    public class CHelperAuthAPI<T> : IHelperAuthAPI<T>
    {
        public IList<T> ResultList { get; private set; }

        public T Result { get; private set; }

        public T GetResult(string method, ExmoApi api, Dictionary<string, string> dic)
        {
            if (dic == null)
                dic=new Dictionary<string, string>();

            var jsonQuery = api.ApiQueryAsync(method, dic);
            var objQuery = JObject.Parse(jsonQuery.Result.ToString());
            var objResult = JsonConvert.DeserializeObject<T>(objQuery.ToString());
            return Result = objResult;
        }
    }
}