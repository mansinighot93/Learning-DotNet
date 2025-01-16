using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;

using Core.Services.Interfaces;
//using Web.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
         private readonly IFinancialsService _financialService;

        public HomeController(IFinancialsService financialService)
        {
            _financialService = financialService;
        }

        public IActionResult Index()
        {
            var totalSold = _financialService.GetTotalSold();
            return View();
        }

        public IActionResult Privacy()
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
