using Microsoft.AspNetCore.Mvc;
using partialViewTest.Models;
using partialViewTest.Services.function;
using System;
using Microsoft.Extensions.Logging;
using partialViewTest.Services.factory;

namespace partialViewTest.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartServiceFactory _cartServiceFactory;

        public CartController(ICartServiceFactory cartServiceFactory)
        {
            _cartServiceFactory = cartServiceFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart(int productId, string cartType = "default")
        {
            var cartService = _cartServiceFactory.CreateService(cartType);
            cartService.AddToCart(productId);
            return Content($"Product added to {cartType} cart");
        }
    }
}
