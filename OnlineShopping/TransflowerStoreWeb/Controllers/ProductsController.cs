using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using Catalog;

namespace TransflowerStoreWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           List<Product> allProducts= Catalog.ProductManager.GetAllProducts();
           this.ViewData["products"]=allProducts;
            return View();  
        }
 
         public ActionResult Details(int id)
        {
            Product Product = ProductManager.Get(id);
            this.ViewData["product"]=Product;
            return View();
        }

        public ActionResult Delete(int id)
        {  
           // ProductManager.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
