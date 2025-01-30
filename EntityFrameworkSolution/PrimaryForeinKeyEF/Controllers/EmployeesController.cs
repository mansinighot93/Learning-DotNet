using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
using Core.Models;
using PrimaryForeinKeyEF.Models;

namespace PrimaryForeinKeyEF.Controllers;

public class EmployeesController : Controller
{
    private readonly IEmployeeService _empService;

    public EmployeesController(IEmployeeService empService)
    {
        _empService = empService;
    }

    public IActionResult Index()
    {
        var emps = _empService.GetAll();
        ViewData["employees"] = emps;
        return View(emps);
    }
    
    public IActionResult Details(int id)
    {
        var employee = _empService.GetById(id);
        ViewData["employee"] = employee;
        if (employee == null) return NotFound();
        return View(employee);
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(Employee employee)
    {
        if (employee != null)
        {
            _empService.Insert(employee);
            return RedirectToAction("Index","Home");
        }
        return View(employee);
    }

    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(Employee employee)
    {
        if (employee != null)
        {
            _empService.Update(employee);
            return RedirectToAction("Index", "Home");
        }
        return View(employee);
    }

    public IActionResult Delete(int id)
    {  
        _empService.Delete(id);
        return RedirectToAction("Index","Home");
    }
}
