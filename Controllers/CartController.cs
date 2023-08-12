using Microsoft.AspNetCore.Mvc;
using partialViewTest.Models;
using partialViewTest.Services;

namespace partialViewTest.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService; 

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart(int productId)
        {
            _cartService.AddToCart(productId);
            return RedirectToAction("Index");
        }
    }
}
