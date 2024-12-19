using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TransflowerStoreWeb.Models;
using PaymentProcessing;



namespace TransflowerStoreWeb.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly ILogger<PaymentsController> _logger;
        public PaymentsController(ILogger<PaymentsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
           List<Payment> allPayments= PaymentManager.GetAll();
                 this.ViewData["payments"]=allPayments;
            return View();  
        }
 
         public ActionResult Details(int id)
        {
            Payment thePayment = PaymentManager.GetById(id);
            this.ViewData["payment"]=thePayment;
            return View();
        }

        public ActionResult Delete(int id)
        {
            PaymentManager.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
