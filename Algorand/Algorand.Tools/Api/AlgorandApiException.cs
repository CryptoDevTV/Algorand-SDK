using System;
using System.Net;

namespace Algorand.Tools.Api
{
    public class AlgorandApiException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }

        public AlgorandApiException(HttpStatusCode statusCode)
            : base($"Request unsuccessful: {(int)statusCode} ({statusCode})")
        {
            StatusCode = statusCode;
        }
    }
}