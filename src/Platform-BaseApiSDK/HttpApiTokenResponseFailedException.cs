using System;

namespace PSC.BaseApiSDK
{
    public class HttpApiTokenResponseFailedException : Exception
    {
        public HttpApiTokenResponseFailedException(string message) : base(message)
        {

        }
    }
}