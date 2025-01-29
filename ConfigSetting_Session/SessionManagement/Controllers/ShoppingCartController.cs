using Microsoft.AspNetCore.Mvc;
using SessionManagement.Models;
using  Core.Models;
using Microsoft.AspNetCore.Http;
using Core.Services.Interfaces;
using SessionManagement.Helpers;
using Core.Services;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Core.Repositories;

namespace SessionManagement.Controllers
{
    public class ShoppingCartController : Controller
    {
        private const string CartSessionKey = "cart";
        private readonly IFlowerService _flowerService;
        private readonly IOrderService _orderService;

        public ShoppingCartController(IFlowerService flowerService, IOrderService orderService)
        {
            _flowerService = flowerService;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if (theCart == null)
            {
                theCart = new Cart();
                theCart.Items = new List<Item>();
            }

            return View(theCart);
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            Flower theFlower = _flowerService.GetById(id);
            Item theItem = new Item();
            theItem.theFlower = theFlower;
            theItem.Quantity = 0;
            return View(theItem);
        }

        [HttpPost]
        public IActionResult Add(Item newItem)
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if (theCart == null)
            {
                theCart = new Cart();
                theCart.Items = new List<Item>(); // Ensure Items is initialized
            }
            theCart.Items.Add(newItem);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index", "shoppingcart");
        }
        public IActionResult Remove(int id)
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            var found = theCart.Items.Find(x => x.theFlower.ID == id);
            if (found != null)
            {
                theCart.Items.Remove(found);
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult BuyNow()
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if (theCart == null || theCart.Items == null || !theCart.Items.Any())
            {
                return RedirectToAction("Index", "home");
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "buyNowCart", theCart);

            //ViewBag.TotalPrice = theCart.Items.Sum(item => item.theFlower.SalePrice * item.Quantity);

            return View(theCart);
        }

        [HttpPost]
        public IActionResult Payment(int userId, List<Order> orders)
        {
            using (var context = new RepoCollectionContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    //ViewBag.ErrorMessage = "User not found.";
                    return RedirectToAction("Login","auth"); 
                }

                foreach (var order in orders)
                {
                    order.UserID = userId;
                    context.Orders.Add(order);
                }

                context.SaveChanges();
            }
            return RedirectToAction("OrderConfirmation");
        }

        [HttpGet]
        public IActionResult OrderConfirmation(int id)
        {
            //var order = _orderService.GetById(id);
            return View();
        }
    }
}
