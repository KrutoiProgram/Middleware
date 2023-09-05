using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.Classes
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RandomMiddleware
    {
        private readonly RequestDelegate _next;

        public RandomMiddleware (RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync (HttpContext httpContext)
        {
            
            await _next(httpContext);
            Random rnd = new Random();
            await httpContext.Response.WriteAsync(rnd.Next().ToString());
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RandomMiddlewareExtensions
    {
        public static IApplicationBuilder UseRandomMiddleware (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RandomMiddleware>();
        }
    }
}
