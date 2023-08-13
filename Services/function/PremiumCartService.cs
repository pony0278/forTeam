using partialViewTest.Models;

namespace partialViewTest.Services.function
{
    public class PremiumCartService : CartServiceBase<CCartVM, CCollectVM>
    {
        private readonly ILogger<PremiumCartService> _logger;

        public override void AddToCart(CCartVM item)
        {
            // 優質購物車的邏輯
        }

        public override void AddToCart(int productId)
        {
            _logger.LogInformation($"[Premium] Product added to cart: {productId}");
        }

        public PremiumCartService(ILogger<PremiumCartService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
