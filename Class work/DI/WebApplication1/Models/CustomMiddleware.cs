
namespace WebApplication1.Models
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from Custome Middleware");
            await next(context);
        }

    }
}
