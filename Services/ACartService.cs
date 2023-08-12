using partialViewTest.Models;

namespace partialViewTest.Services
{
    public abstract class BaseCartService<T, U> 
        where T : CCartVM
        where U : CCollectVM
    {
        public abstract void AddToCart(T item);
        public abstract void AddToCart(int productId);
    }
}
