using System.Net.Http.Headers;

namespace PSC.BaseApiSDK
{
    public class BearerAuthorizedApiClient : RestApiHttpClient
    {
        public BearerAuthorizedApiClient(string token)
        {
            this.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}