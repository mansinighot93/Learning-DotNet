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
    public class FlowersController : Controller
    {
         private readonly IFlowerService _flowerService;

         public FlowersController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }

        public IActionResult Index()
        {
            var itemsSold = _flowerService.GetAllSold();
            return View(itemsSold);
        }
    }
}
