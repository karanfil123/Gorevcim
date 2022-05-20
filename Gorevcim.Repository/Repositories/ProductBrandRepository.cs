using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class ProductBrandRepository : GenericRepository<ProductsBrand>,IProductBrandRepository
    {
        public ProductBrandRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }
    }
}
