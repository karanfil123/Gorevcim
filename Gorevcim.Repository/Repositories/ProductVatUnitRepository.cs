using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class ProductVatUnitRepository : GenericRepository<ProductVatUnit>, IProductVatUnitRepository
    {
        public ProductVatUnitRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }
    }
}
