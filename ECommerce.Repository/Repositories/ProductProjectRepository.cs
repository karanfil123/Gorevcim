using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class ProductProjectRepository : GenericRepository<ProductProject>, IProductProjectRepository
    {
        public ProductProjectRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }
    }
}
