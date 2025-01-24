
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BIApp.Models;

namespace BIApp.Controllers
{
    public class DashboardController : Controller
    {
        public JsonResult CityRevenue(){
     
            var revenueList=RevenueDataAccessLayer.GetCityRevenueList();
            return Json(revenueList);
        }

        public JsonResult StateRevenue()  
        {  
            var RevenueList = RevenueDataAccessLayer.GetStateRevenueList();
            return Json(RevenueList);  
        }  
        public IActionResult Index()  
        {  
            return View();  
        }  
        public IActionResult BarChart()  
        {  
            return View();  
        }  
        public IActionResult LineChart()  
        {  
            return View();  
        }  
        public IActionResult PieChart()  
        {  
            return View();  
        }  
    }
}