using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LearningApp.Models;
using Catalog;

namespace LearningApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        List<Product> allProducts = ProductManager.GetAllProducts();
        ViewData["products"] = allProducts;
        return View();
    
    }

    public IActionResult Details(int id)
    {
        Product Product = ProductManager.Get(id);
        this.ViewData["product"] = Product;
        return View();
    }

     public IActionResult Delete(int id)
    {  
        ProductManager.Delete(id);
        return RedirectToAction("Index");
    }

    [HttpGet]

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id,string title,string description,int quantity,double unitprice,string imageUrl)
    {
        Product product = new Product()
        {
            Id=id,
            Title=title,
            Description=description,
            Quantity=quantity,
            UnitPrice=unitprice,
            ImageUrl=imageUrl
        };
        ProductManager.Insert(product);
        return RedirectToAction("index","products");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        //data was transfered to view using ViewData
        //data was transfered to view using ViewBag
        //data was transfered to view using model binding
        Product product = ProductManager.Get(id);
        return View(product);
    }

    [HttpPost]
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
