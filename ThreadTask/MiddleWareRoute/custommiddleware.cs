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
                await context.Response.WriteAsync(" <h1>First Middleware</h1> ");
                await next();
            });
        }
        public static void UseSecondMiddleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync(" <h2>Second Middleware</h2> ");
                await next();
            });
        }
        public static void UseLastMiddleware(this IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync(" <ol><li>Programming Language</li><li>C# Projects</li></ol> ");
            });
        }
    }  
}