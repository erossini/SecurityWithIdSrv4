using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PSC.BaseApiSDK
{
    public interface IRestApiHttpClient
    {
        Task<T> GetFromApiAsync<T>(string url);
        Task<IList<T>> GetCollectionFromApiAsync<T>(string url);
    }
}
