using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionApp.Models;
using DependencyInjectionApp.Services;

namespace DependencyInjectionApp.Controllers;

public class HomeController : Controller
{
    private readonly IHelloWorldService _hellowolrdservices;
    private readonly IProductCatalogService _productcatalogservice;

    public HomeController(IHelloWorldService hellowolrdservices,IProductCatalogService productcatalogservice)
    {
        this._hellowolrdservices = hellowolrdservices;
        this._productcatalogservice = productcatalogservice;
    }

    public IActionResult Index()
    {
        string message = this.IHelloWorldService.SayHello();
        ViewData["message"] = message;
        bool status = this.IProductCatalogService.Insert();
        return View();
    }

    public IActionResult Privacy()
    {
        string message = this.IHelloWorldService.SayHello();
        ViewData["message"] = message;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
