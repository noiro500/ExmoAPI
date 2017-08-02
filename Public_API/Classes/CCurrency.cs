using System.Collections.Generic;
using System.Linq;

namespace ExmoAPI.Public_API.Classes
{
    //Cписок валют биржи
    public static class CCurrency
    {
        public static List<string> CurrencyList { get; set; }

        public static void GetCurrency(ExmoApi api)
        {
            var jsonCurrency = api.ApiQueryAsync("currency", new Dictionary<string, string>());
            var parserStrings = jsonCurrency.Result.ToString()
                .Replace('[', ' ')
                .Replace(']', ' ')
                .Replace('"', ' ').Trim()
                .Split(',');
            CurrencyList = parserStrings.Cast<string>().ToList();
        }
    }
}