using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ExmoAPI.Public_API.Classes
{
    //Cписок валют биржи
    public static class CCurrency
    {
        public static List<string> CurrencyList { get; set; }
        public static List<string> CurrencyPairList { get; set; }

        public static IList<string> GetCurrency(ExmoApi api)
        {
            var jsonCurrency = api.ApiQueryAsync("currency", new Dictionary<string, string>());
            var parserStrings = jsonCurrency.Result.ToString()
                .Replace("[", "")
                .Replace("]", "")
                .Replace("\"", "")
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return CurrencyList = parserStrings.Cast<string>().ToList();
        }

        public static IList<string> GetCurrencyPairList(ExmoApi api)
        {
            var jsonPairSettings = api.ApiQueryAsync("pair_settings", new Dictionary<string, string>());
            var objPairSettings = JObject.Parse(jsonPairSettings.Result.ToString());
            var tempReplace = objPairSettings.ToString()
                .Replace("{", "")
                .Replace("}", "")
                .Replace("\"", "")
                .Replace(":", "")
                .Replace("min_quantity", "")
                .Replace("max_quantity", "")
                .Replace("min_price", "")
                .Replace("max_price", "")
                .Replace("max_amount", "")
                .Replace("min_amount", "")
                .Replace(".", " ").Replace(",", " ");
            var tempArray = tempReplace.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
            var resultString = (new string(tempArray)).Replace(System.Environment.NewLine, "")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return CurrencyPairList = resultString.ToList();
        }

    }
}