using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using CRM;

namespace TransflowerStoreWeb.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
           List<Customer> allCustomers= CRM.CustomerManager.GetAll();
           this.ViewData["customers"]=allCustomers;
            return View();  
        }
         public ActionResult Details(int id)
        {
            Customer theCustomer =CustomerManager.GetById(id);
            this.ViewData["customer"]=theCustomer;
            return View();
        }

        public ActionResult Delete(int id)
        { 
            CustomerManager.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
