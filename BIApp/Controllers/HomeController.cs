using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BIApp.Models;

namespace BIApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Aboutus()
    {
        string name = "Transflower learning pvt.Ltd";
        ViewData["company"]=name;
        return View();
    }

    public IActionResult ContactUs()
    {
        string url = "www.transflower.in";
        var product = new Product {ID=23,Title="Rose"};
        ViewBag.product = product;
        ViewBag.website = url;
        ViewBag.school = "Transflower school";
        ViewBag.age = 35;
        return View();
    }

    public IActionResult Services()
    {
        string service = "transforming Digital India";
        TempData["vision"] = service;
        return View();
    }
    public IActionResult SalesView()
    {
        SalesRepository list = new SalesRepository();
        ViewBag.Message = "Transflower Sales";
        return View(list);
    }

    public IActionResult Students()
    {
        List<string> data = new List<string>();
        data.Add("Manasi");
        data.Add("Rutuja");
        data.Add("Manva");
        data.Add("Anaya");
        var result = data.ToArray();
        return new JsonResult(result);
    }
    public IActionResult List()
    {
        SalesRepository repository = new SalesRepository();
        return new JsonResult(repository);
    }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
