using partialViewTest.Models;
using System;
using Microsoft.Extensions.Logging;

namespace partialViewTest.Services.function

{
    public class CartService : CartServiceBase<CCartVM, CCollectVM>
    {
        private readonly ILogger<CartService> _logger;

        public override void AddToCart(CCartVM item)
        {
            // 實現添加到購物車的邏輯
            try
            {
                // 嘗試執行添加邏輯
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding item to cart");
                throw; // 或者進行自定義的錯誤處理
            }
        }

        public override void AddToCart(int productId)
        {
            _logger.LogInformation($"Product added to cart: {productId}");
        }

        public CartService(ILogger<CartService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }

}
