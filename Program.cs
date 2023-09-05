using System.Text;
using WebApplication1.Classes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<HelloWorldMiddleware>();

//app.UseMiddleware<RandomMiddleware>();
//app.UseRouting();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/", async context =>
//    {
//        await context.Response.WriteAsync("<a href='/connection'>connection info</a>");
//    });
//    endpoints.MapGet("/request", async context =>
//    {
//        StringBuilder result = new StringBuilder();
//        result.AppendLine($"Path: {context.Request.Path.Value}");
//        result.AppendLine($"Method: {context.Request.Method}");
//        result.AppendLine($"Status Code: {context.Response.StatusCode}");
//        result.AppendLine("Headers:");

//        foreach (var header in context.Request.Headers)
//        {
//            result.AppendLine($"{header.Key} : {header.Value}");
//        }

//        await context.Response.WriteAsync(result.ToString());

//    });

//    endpoints.MapGet("/connection", async context =>
//    {
//        await context.Response.WriteAsync("Remote ip: " +
//            context.Connection.RemoteIpAddress.ToString());
//        await context.Response.WriteAsync("\nLocal ip: " +
//            context.Connection.LocalIpAddress.ToString());
//        // или context.Connection.LocalIpAddress.MapToIPv4().ToString(), чтобы явно указать ipv4 адрес
//    });
//    endpoints.MapGet("/params", async context =>
//    {
//        await context.Response.WriteAsync(
//            $"Query String: {context.Request.QueryString.Value}\n");

//        foreach (var param in context.Request.Query)
//        {
//            await context.Response.WriteAsync(
//                $"{param.Key} = {param.Value}\n");
//        }
//    });
//    endpoints.MapGet("/square", async context =>
//    {
//        int value = 0;

//        if (context.Request.Query.ContainsKey("value"))
//        {
//            if (int.TryParse(context.Request.Query["value"], out value))
//            {
//                await context.Response
//                    .WriteAsync($"{value}^2 = {value * value}");
//            } else
//            {
//                await context.Response.WriteAsync($"Invalid value");
//            }
//        } else
//        {
//            await context.Response.WriteAsync($"Invalid request");
//        }


//    });
//    endpoints.MapGet("/power", async context =>
//    {
//        int a = 0;
//        int b = 0;

//        if (context.Request.Query.ContainsKey("a")&& context.Request.Query.ContainsKey("b"))
//        {
//            if (int.TryParse(context.Request.Query["a"], out a)&& int.TryParse(context.Request.Query["b"], out b))
//            {
//                await context.Response
//                    .WriteAsync($"{a}^{b} = {Math.Pow(a,b)}");
//            } else
//            {
//                await context.Response.WriteAsync($"Invalid value");
//            }
//        } else
//        {
//            await context.Response.WriteAsync($"Invalid request");
//        }


//    });
    
//});
app.Run();
