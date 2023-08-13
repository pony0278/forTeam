using partialViewTest.Models;
using partialViewTest.Services.function;

namespace partialViewTest.Services.factory
{
    public interface ICartServiceFactory
    {
        CartServiceBase<CCartVM, CCollectVM> CreateService(string type);
    }
}
