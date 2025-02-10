using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Core.Services.Interfaces;



public class TransactionsController : Controller
{
    private readonly ITransactionService _transService;

    public TransactionsController(ITransactionService transService)
    {
        _transService = transService;
    }

    public IActionResult Index()
    {
        var transactions = _transService.GetAll();
        ViewData["transactions"] = transactions;
        return View(transactions);
    }

    public IActionResult Details(int id)
    {
        var transaction = _transService.GetById(id);
        ViewData["transaction"] = transaction;
        if (transaction == null) return NotFound();
        return View(transaction);
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(Transaction transaction)
    {
        if (transaction != null)
        {
            _transService.Insert(transaction);
            return RedirectToAction("Index", "Home");
        }
        return View(transaction);
    }

    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(Transaction transaction)
    {
        if (transaction != null)
        {
            _transService.Update(transaction);
            return RedirectToAction("Index", "Home");
        }
        return View(transaction);
    }

    public IActionResult Delete(int id)
    {
        _transService.Delete(id);
        return RedirectToAction("Index", "Home");
    }
}
