using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LearningApp.Models;
using OrderProcessing;

namespace LearningApp.Controllers;

public class OrdersController : Controller
{
    private readonly ILogger<OrdersController> _logger;

    public OrdersController(ILogger<OrdersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Orders> allOrders = OrderManager.GetAllOrder();
        ViewData["orders"] = allOrders;
        return View();
    }

    public IActionResult Details(int id)
    {
        Orders order = OrderManager.GetById(id);
        this.ViewData["order"] = order;
        return View();
    }

     public IActionResult Delete(int id)
    {  
        OrderManager.Delete(id);
        return RedirectToAction("Index");
    }

    [HttpGet]

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id,DateTime date,string status,double amount)
    {
        Orders order = new Orders()
        {
            Id=id,
            OrderDate=date,
            Status=status,
            TotalAmount=amount
        };
        OrderManager.Insert(order);
        return RedirectToAction("index","orders");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        //data was transfered to view using ViewData
        //data was transfered to view using ViewBag
        //data was transfered to view using model binding
        Orders order = OrderManager.GetById(id);
        return View(order);
    }

    [HttpPost]
    public IActionResult Update(Orders modifiedorder)
    {
        OrderManager.Update(modifiedorder);
        return RedirectToAction("index","orders");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
