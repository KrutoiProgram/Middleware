namespace WebApplication1.Classes
{
    public class TimeMiddleware
    {
        private RequestDelegate next;

        public TimeMiddleware (RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync (HttpContext context)
        {
            await next.Invoke(context);
            await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
        }
    }
}
