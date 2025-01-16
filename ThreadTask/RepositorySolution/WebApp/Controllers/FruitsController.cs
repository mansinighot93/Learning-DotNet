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
    public class FruitsController : Controller
    {
        private readonly IFruitService _fruitService;

        public FruitsController(IFruitService fruitService)
        {
            _fruitService = fruitService;
        }

        public IActionResult Index()
        {
            var Fruits = _fruitService.GetAllSold();
            return View(Fruits);
        }
    }
   
}
