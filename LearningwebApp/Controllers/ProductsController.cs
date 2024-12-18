using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearningwebApp.Models;

namespace LearningwebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<string> products =new List<string>();
        products.Add("Lotus");
        products.Add("Gerbera");
        products.Add("Rose");
        products.Add("Marigold");
        products.Add("Jasmine");
        products.Add("Carnation");

        ViewData["allProducts"] = products;
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Update()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
