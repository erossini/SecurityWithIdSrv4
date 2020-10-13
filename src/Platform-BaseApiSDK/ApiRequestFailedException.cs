using System;
using System.Net;
using System.Net.Http;

namespace PSC.BaseApiSDK
{
    public class HttpApiRequestFailedException : Exception
    {
        public HttpResponseMessage Response { get; }
        public HttpStatusCode StatusCode => Response.StatusCode;


        public HttpApiRequestFailedException(HttpResponseMessage response)
        {
            Response = response;
        }
    }
}
