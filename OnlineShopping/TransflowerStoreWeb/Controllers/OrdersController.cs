using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using OrderProcessing;

namespace TransflowerStoreWeb.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           List<Order> allOrders= OrderManager.GetAll();
           this.ViewData["orders"]=allOrders;
            return View();  
        }
 
         public ActionResult Details(int id)
        {
            Order order = OrderManager.GetById(id);
            this.ViewData["order"]=order;
            return View();
        }

        public ActionResult Delete(int id)
        {
            OrderManager.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
