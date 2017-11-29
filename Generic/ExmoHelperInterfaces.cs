using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExmoAPI.Generic
{
    public interface IHelperPublicAPI<T>
    {
        IList<T> ResultList { get; }
        //T Result { get; }
        Task<T> GetResult(string method, ExmoApi api, string currentPair);
    }

    public interface IHelperAuthAPI<T>
    {
        IList<T> ResultList { get; }
        T Result { get; }
        Task<T> GetResult(string method, ExmoApi api, Dictionary<string, string> dic=null, string currentPair=null);
    }

}