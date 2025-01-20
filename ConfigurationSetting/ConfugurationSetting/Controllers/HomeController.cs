using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConfugurationSetting.Models;

namespace ConfugurationSetting.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
    {
        _logger = logger;
        _configuration=configuration;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Connect()
    {
        string conString = string.Empty;
        
        //Configuration class have different signature
        var connection = _configuration.GetValue<string>("ConnectionStrings:ConnectionStringsDB");
        var connection1 = _configuration.GetSection("ConnectionStrings").GetSection("ConnectionStringsDB").Value;
        var connection2 = _configuration["ConnectionStrings:ConnectionStringsDB"];
        var connection3 = _configuration.GetConnectionString("ConnectionStrings:ConnectionStringsDB");

        
        List<string> connectionStrings = new List<string>();
        connectionStrings.Add(connection);
        connectionStrings.Add(connection1);
        connectionStrings.Add(connection2);
        connectionStrings.Add(connection3);
        
        ViewData["connectionStrings"] = connectionStrings;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult QueryTest()
    {
        string name = string.Empty;
        name= HttpContext.Request.Query["name"];
        string city = string.Empty;
        city= HttpContext.Request.Query["city"];
        string state = string.Empty;
        state= HttpContext.Request.Query["state"];
        return Content("Invoking the query test...." + name + " " + city + " " + state);
    }

    public IActionResult Student()
    {
        List<string> name = new List<string>();
        name.Add("Manasi");
        name.Add("Soham");
        name.Add("Anaya");
        name.Add("Mahi");

        var result = name.ToArray();
        return new JsonResult(result);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
