using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.Classes
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HelloWorldMiddleware
    {
        private readonly RequestDelegate _next;

        
        public HelloWorldMiddleware (RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync (HttpContext httpContext)
        {
            await _next(httpContext);
            if (httpContext.Request.Query.ContainsKey("name"))
            {
                
                if (string.IsNullOrWhiteSpace(httpContext.Request.Query["name"]))
                {
                    await httpContext.Response.WriteAsync("Hello, World!");
                } 
                else
                {
                    await httpContext.Response.WriteAsync($"Hello, {httpContext.Request.Query["name"].ToString()}!");
                }
            }
            else
            {
                httpContext.Response.StatusCode = 400;
                await httpContext.Response.WriteAsync("Invalid Requset");
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HelloWorldMiddlewareExtensions
    {
        public static IApplicationBuilder UseHelloWorldMiddleware (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloWorldMiddleware>();
        }
    }
}
