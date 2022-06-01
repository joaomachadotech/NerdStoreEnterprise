using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NSE.WebApp.MVC.Extensions
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (CustomHttpResquetException e)
            {
                HandleRequestExceptionAsync(httpContext, e);
            }
        }


        private static void HandleRequestExceptionAsync(HttpContext context,
            CustomHttpResquetException httpResquetException)
        {
            if (httpResquetException.StatusCode == HttpStatusCode.Unauthorized)
            {
                context.Response.Redirect("/login");
                return;
            }
            context.Response.StatusCode = (int)httpResquetException.StatusCode;
        }
    }
}
