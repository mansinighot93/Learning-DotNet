using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConfugurationSetting.Models;
using System.Text.Json;

namespace ConfugurationSetting.Controllers;
    [Serializable]
    public class Cart{
        public List<string> Items = new List<string>();
        public Cart(){
            Items.Add("Smart Phone");
            Items.Add("Laptop");
            Items.Add("Desktop");
            Items.Add("Camera");
        }
    }
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
        //Will store string,integer and complex object in to session maintained inside distributed cache at server side
        string SessionKeyName = "product";
        string SessionKeyAge = "age";
        HttpContext.Session.SetString(SessionKeyName,"Dell Computer");
        HttpContext.Session.SetInt32(SessionKeyAge,45);
        var theCart = new Cart();
        var str = JsonSerializer.Serialize(theCart);
        HttpContext.Session.SetString("cart",str);
        return View();
    }

    public IActionResult Privacy()
    {
        //Get data from sever side session variable which is kept in distributed cache of server
        ViewBag.data = HttpContext.Session.GetString("product");
        var strTheCart = HttpContext.Session.GetString("cart");
        ViewData["cart"] = JsonSerializer.Deserialize<Cart>(strTheCart); 
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
