using System.Collections.Generic;

namespace ExmoAPI.Generic
{
    public interface IHelperPublicAPI<T>
    {
        IList<T> ResultTradesList { get; }
        T ResultList { get; }

        //IList<T> GetResultTradesList(string method, string currentPair, ExmoApi api);
        T GetResult(string method, string currentPair, ExmoApi api);
    }

}