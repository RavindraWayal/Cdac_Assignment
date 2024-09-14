namespace WebApplication1.Models
{
    public class Middleware
    {
        private readonly RequestDelegate next;
        public Middleware(RequestDelegate next)
        { this.next = next; }

        public async Task Invoke(HttpContext context)
        {
            await next(context);
        }
    }
    public static class  MiddlewareExtension
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<Middleware>();        
        }
    }
}
