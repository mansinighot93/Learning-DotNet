using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Core.Services.Interfaces;



public class AccountsController : Controller
{
    private readonly IAccountService _accountService;

    public AccountsController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    public IActionResult Index()
    {
        var acc = _accountService.GetAll();
        ViewData["accounts"] = acc;
        return View(acc);
    }

    public IActionResult Details(int id)
    {
        var account = _accountService.GetById(id);
        ViewData["account"] = account;
        if (account == null) return NotFound();
        return View(account);
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(Account account)
    {
        if (account != null)
        {
            _accountService.Insert(account);
            return RedirectToAction("Index", "Home");
        }
        return View(account);
    }

    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(Account account)
    {
        if (account != null)
        {
            _accountService.Update(account);
            return RedirectToAction("Index", "Home");
        }
        return View(account);
    }

    public IActionResult Delete(int id)
    {
        _accountService.Delete(id);
        return RedirectToAction("Index", "Home");
    }
}
