using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
using Core.Models;
using Core.Services;
using SessionManagement.Helpers;
using SessionManagement.Models;
public class OrdersController : Controller
    {
         private readonly IOrderService _orderService;
         public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var itemsSold = _orderService.GetAll();
            return View(itemsSold);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Order order)
        {
            if (order != null)
            {
            _orderService.Insert(order);
                return RedirectToAction("Index", "Home");
            }
            return View(order);
        }
}