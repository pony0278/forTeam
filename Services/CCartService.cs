using partialViewTest.Models;

namespace partialViewTest.Services
{
    public class CartService : BaseCartService<CCartVM, CCollectVM>
    {
        public override void AddToCart(CCartVM item)
        {
            // 實現邏輯
        }
        public override void AddToCart(int productId)
        {

        }
        // 其他方法
    }
}
