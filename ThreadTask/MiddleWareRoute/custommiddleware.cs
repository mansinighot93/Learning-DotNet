using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MiddleWareRoute
{
    public static class ExtensionClass
    {
        //define your custom middleware with the help extenstion method
        public static void UseFirstMiddleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("First Middleware");
                await next();
            });
        }
        public static void UseSecondMiddleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second Middleware");
                await next();
            });
        }
        public static void UseLastMiddleware(this IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Last Middleware");
            });
        }
    }  
}