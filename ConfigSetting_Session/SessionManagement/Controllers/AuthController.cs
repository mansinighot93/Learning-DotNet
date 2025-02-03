using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
using Core.Models;

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
            HttpContext.Session.SetInt32("UserID", user.Id);
            return RedirectToAction("orderconfirmation", "shoppingcart");
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
        User register = new User
        {
            Id = id,
            Name = name,
            Location = location,
            Email = email,
            Password = password,
            ContactNumber = contactnumber
        };
        _authService.Register(register);
        return RedirectToAction("Success");
    }
    [HttpGet]
    public IActionResult ForgotPassword()
    {
        return View();
    }
    [HttpPost]
    public IActionResult ForgotPassword(string username,string newPassword,string confirmPassword)
    {
        var user = _authService.ForgotPassword(username, newPassword, confirmPassword);
        if (user != null)
        {
            HttpContext.Session.SetString("UserId", user.ToString());
            return RedirectToAction("Login", "auth");
        }

        ViewBag.Message = "Failed to update password. Please check your inputs.";
        return View();
    }
    public IActionResult Success()
    {
        return View();
    }
}