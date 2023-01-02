using Gorevcim.Core;
using Gorevcim.Core.Repositories;

namespace Gorevcim.Repository.Repositories
{
    public class ProductCurrencyRepository : GenericRepository<ProductCurrencyUnit>, IProductCurrencyUnitRepository
    {
        public ProductCurrencyRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }
    }
}
