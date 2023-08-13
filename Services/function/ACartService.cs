using partialViewTest.Models;

namespace partialViewTest.Services.function
{
    public abstract class CartServiceBase<TCartItem, TCollectItem>
        where TCartItem : CCartVM
        where TCollectItem : CCollectVM
    {
        public abstract void AddToCart(TCartItem item);
        public abstract void AddToCart(int productId);
    }

}
