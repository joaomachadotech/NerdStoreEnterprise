using System;
using System.Net;

namespace NSE.WebApp.MVC.Extensions
{
    public class CustomHttpResquetException : Exception
    {
        public HttpStatusCode StatusCode;

        public CustomHttpResquetException() { }

        public CustomHttpResquetException(string message, Exception innerException)
        : base(message, innerException) { }

        public CustomHttpResquetException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
