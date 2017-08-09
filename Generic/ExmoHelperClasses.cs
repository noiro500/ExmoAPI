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
        public IList<T> ResultTradesList { get; private set; }
        public T ResultList { get; private set; }

        private IList<T> GetResultTradesList(string method, string currentPair, ExmoApi api)
        {
            var jsonQuery = api.ApiQueryAsync(method, new Dictionary<string, string>(), currentPair);
            var objQuery = JObject.Parse(jsonQuery.Result.ToString());
            var objResult = JsonConvert.DeserializeObject<T[]>(objQuery[currentPair].ToString());
            return ResultTradesList = objResult.ToList();
        }

        public T GetResult(string method, string currentPair, ExmoApi api)
        {
            if (method == "trades")
            {
                GetResultTradesList(method, currentPair, api);
                return ResultList;
            }
            var jsonQuery = api.ApiQueryAsync(method, new Dictionary<string, string>(), currentPair);
            var objQuery = JObject.Parse(jsonQuery.Result.ToString());
            var objResult = JsonConvert.DeserializeObject<T>(objQuery[currentPair].ToString());
            return ResultList = objResult;

        }
    }
}