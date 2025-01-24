using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
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
    }