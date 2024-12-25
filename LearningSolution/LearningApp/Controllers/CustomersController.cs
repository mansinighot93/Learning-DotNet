using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LearningApp.Models;
using CRM;

namespace LearningApp.Controllers;

public class CustomersController : Controller
{
    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Customers> allCustomers = CustomerManager.GetAllCustomers();
        ViewData["customer"] = allCustomers;
        return View();
    }

    public IActionResult Details(int id)
    {
        Customers customer = CustomerManager.GetById(id);
        this.ViewData["customer"] = customer;
        return View();
    }

     public IActionResult Delete(int id)
    {  
        CustomerManager.Delete(id);
        return RedirectToAction("Index");
    }

    [HttpGet]

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id,string name,int contactNumber,string email,string location,int age)
    {
        Customers customer = new Customers()
        {
            Id=id,
            Name=name,
            ContactNumber=contactNumber,
            Email=email,
            Location=location,
            Age=age
        };
        CustomerManager.Insert(customer);
        return RedirectToAction("index","customers");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        //data was transfered to view using ViewData
        //data was transfered to view using ViewBag
        //data was transfered to view using model binding
        Customers customer = CustomerManager.GetById(id);
        return View(customer);
    }

    [HttpPost]
    public IActionResult Update(Customers modifiedCustomer)
    {
        CustomerManager.Update(modifiedCustomer);
        return RedirectToAction("index","customers");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
