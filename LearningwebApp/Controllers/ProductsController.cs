using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearningwebApp.Models;
using Catalog;

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

    [httpGet]

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(string title,string description,int quantity,double unitprice)
    {
        Product product = new Product(){
            Id=78,
            Title=title,
            Description=description,
            Quantity=quantity,
            UnitPrice=unitprice
        }
        ProductManager.Insert(product);
        return View();
    }

    [httpGet]
    public IActionResult Update(int id)
    {
        //data was transfered to view using ViewData
        //data was transfered to view using ViewBag
        //data was transfered to view using model binding
        Product product = ProductManager.Get(id);
        return View(product);
    }

    [httpPost]
    public IActionResult Update(Product modifiedProduct)
    {
        ProductManager.Update(modifiedProduct);
        return RedirectToAction("index","products");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
