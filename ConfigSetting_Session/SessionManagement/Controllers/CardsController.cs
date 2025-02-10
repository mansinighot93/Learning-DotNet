using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
using Core.Models;
using SessionManagement.Models;

public class CardsController : Controller
{
    private readonly ICardService _cardService;

    public CardsController(ICardService cardService)
    {
        _cardService = cardService;
    }

    public IActionResult Index()
    {
        var cards = _cardService.GetAll();
        ViewData["cards"] = cards;
        return View(cards);
    }

    public IActionResult Details(int id)
    {
        var card = _cardService.GetById(id);
        ViewData["card"] = card;
        if (card == null) return NotFound();
        return View(card);
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(Card card)
    {
        if (card != null)
        {
            _cardService.Insert(card);
            return RedirectToAction("Index", "Home");
        }
        return View(card);
    }

    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(Card card)
    {
        if (card != null)
        {
            _cardService.Update(card);
            return RedirectToAction("Index", "Home");
        }
        return View(card);
    }

    public IActionResult Delete(int id)
    {
        _cardService.Delete(id);
        return RedirectToAction("Index", "Home");
    }
}
