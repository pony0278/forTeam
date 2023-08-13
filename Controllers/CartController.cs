using Microsoft.AspNetCore.Mvc;
using partialViewTest.Models;
using partialViewTest.Services.function;
using System;
using Microsoft.Extensions.Logging;

namespace partialViewTest.Controllers
{
    public class CartController : Controller
    {
        private readonly CartServiceBase<CCartVM, CCollectVM> _cartService;

        public CartController(CartServiceBase<CCartVM, CCollectVM> cartService)
        {
            _cartService = cartService ?? throw new ArgumentNullException(nameof(cartService));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart(int productId)
        {
            _cartService.AddToCart(productId);
            return Content("Index");
        }
    }
}
