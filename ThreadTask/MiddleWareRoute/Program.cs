using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiddleWareRoute;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//app.UseFirstMiddleware();
//app.UseSecondMiddleware();
//app.UseLastMiddleware();
//app.MapGet("/", () => "Hello World!");

app.UseWelcomePage();   //inbuilt middleware
//app.UseStaticFiles();   ///inbuilt middleware

app.Run();

