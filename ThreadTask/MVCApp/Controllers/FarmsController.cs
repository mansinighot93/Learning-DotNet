using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class FarmsController : Controller
    {

        // get a specific unit at a specific property:
        //~/farms/farmname/greenhouse/unitNo
        public IActionResult GreenhouseDetails(string farmName, string unitNo)
        {
            Console.WriteLine("Farm name = "+ farmName + " Greenhouse name = "+ unitNo);
            return View( );
        }

        // get a specific unit at a specific property:
        //~/farms/farmname/greenhouse/unitNo/crop/23
        public IActionResult CropDetails(string farmName, string unitNo,string cropName)
        {
            Console.WriteLine("Farm name = "+ farmName + " Greenhouse name = "+ unitNo + " Crop name" +cropName);
            return View();
        }

        // get a specific unit at a specific property:
        //~/farms/farmname/greenhouse/unitNo/crop/23/date/dt
        public IActionResult CropDateDetails(string farmName, string unitNo, string cropName,string date)
        {
            Console.WriteLine("Farm name = "+ farmName + " Greenhouse name = "+ unitNo + "Crop name" +cropName + "Date "+ date);
            return View();
        }
    }
}