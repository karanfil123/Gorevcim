using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetAllWebProductsCategory()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }

        public async Task<Product> GetWebProductByIdCategory(int productId)
        {
           return await _context.Products.Include(x=>x.Category).Where(x=>x.Id==productId).SingleOrDefaultAsync();
        }
    }
}
