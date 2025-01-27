using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;

using SessionManagement.Models;
public class AuthController : Controller
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        var user = _authService.Validate(username, password);

        if (user != null)
        {
            return RedirectToAction("Index","home");
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid email or password. Please try again.";
            return View();
        }
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(int id, string name, string location, string email, string password, long contactnumber)
    {
        Register register = new Register
        {
            Id = id,
            Name = name,
            Location = location,
            Email = email,
            Password = password,
            ContactNumber = contactnumber
        };
        _authService.Insert(register);
        return RedirectToAction("Success");
    }
    public IActionResult Success()
    {
        return View();
    }
}