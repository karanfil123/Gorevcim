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
        
        public async Task<List<Product>> GetProductCategory()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
