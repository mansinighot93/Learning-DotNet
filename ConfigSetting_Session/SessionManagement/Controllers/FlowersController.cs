using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
public class FlowersController : Controller
    {
         private readonly IFlowerService _flowerService;
         public FlowersController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }

        public IActionResult Index()
        {
            var itemsSold = _flowerService.GetAll();
            return View(itemsSold);
        }
    }