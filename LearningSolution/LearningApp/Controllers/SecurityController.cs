using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearningApp.Models;
using Membership;

namespace LearningApp.Controllers;

public class SecurityController : Controller
{
    private readonly ILogger<SecurityController> _logger;

    public SecurityController(ILogger<SecurityController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login(string username, string password)
    {
        SecurityManager.Validate(username,password);
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
