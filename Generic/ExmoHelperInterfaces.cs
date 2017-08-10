using System.Collections.Generic;

namespace ExmoAPI.Generic
{
    public interface IHelperPublicAPI<T>
    {
        IList<T> ResultTradesList { get; }
        T Result { get; }
        T GetResult(string method, string currentPair, ExmoApi api);
    }

    public interface IHelperAuthAPI<T>
    {
        IList<T> ResultList { get; }
        T Result { get; }
        T GetResult(string method, Dictionary<string, string> dic, ExmoApi api);
    }

}