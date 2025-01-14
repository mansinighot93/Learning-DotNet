using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCApp.Models;


namespace MVCApp.Controllers
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
           
            return View();  
        }
        
        public ActionResult Details(int id)
        {
            
            return View();
        }

        public ActionResult Delete(int id)
        {      
            return RedirectToAction("Index");
        }
 
        [HttpGet]
        public IActionResult Insert()
        {
           return View();  
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View();  
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
