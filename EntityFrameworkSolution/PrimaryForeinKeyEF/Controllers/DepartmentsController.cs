using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
using Core.Models;
using PrimaryForeinKeyEF.Models;

namespace PrimaryForeinKeyEF.Controllers;

public class DepartmentsController : Controller
{
    private readonly IDepartmentService _deptService ;

    public DepartmentsController(IDepartmentService deptService)
    {
        _deptService = deptService;
    }

    public IActionResult Index()
    {
        var dept = _deptService.GetAll();
        return View(dept);
    }

    
}
