using Microsoft.AspNetCore.Cors.Infrastructure;
using partialViewTest.Models;
using partialViewTest.Services.function;

namespace partialViewTest.Services.factory
{
    public class CartServiceFactory : ICartServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public CartServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public CartServiceBase<CCartVM, CCollectVM> CreateService(string type)
        {
            switch (type)
            {
                case "premium":
                    return _serviceProvider.GetRequiredService<PremiumCartService>();
                default:
                    return _serviceProvider.GetRequiredService<CartService>();
            }
        }
    }
}
