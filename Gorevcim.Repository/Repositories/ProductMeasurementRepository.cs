using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class ProductMeasurementRepository : GenericRepository<ProductMeasurementUnit>, IProductMeasurementUnitRepository
    {
        public ProductMeasurementRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }
    }
}
