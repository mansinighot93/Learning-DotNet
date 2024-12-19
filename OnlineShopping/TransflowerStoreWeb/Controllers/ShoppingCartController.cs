using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using ShoppingCart;

namespace TransflowerStoreWeb.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ILogger<ShoppingCartController> _logger;
        public ShoppingCartController(ILogger<ShoppingCartController> logger)
        {
            _logger = logger;
        }

         public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult RemoveFromCart(int id)
        { //Logic for removing item from Shopping cart kept in session
            return RedirectToAction("index");
        }
 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
