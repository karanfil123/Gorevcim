using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories.UnitOfWorks
{
    public class ProductColorRepository : GenericRepository<ProductsColor>, IProductColorRepository
    {
        public ProductColorRepository(AppDbContext.AppDbContext context) : base(context)
        {

        }

        public async Task<List<Product>> GetProductColorByProduct(int productId)
        {
            return await _context.ProductsColors.Include(x=>x.ProductFeatures)
        }
    }
}
