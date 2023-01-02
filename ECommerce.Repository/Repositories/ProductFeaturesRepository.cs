using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class ProductFeaturesRepository : GenericRepository<ProductFeatures>, IProductFeaturesRepository
    {
        public ProductFeaturesRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }
    }
}
