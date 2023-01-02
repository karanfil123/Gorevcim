using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.Services;
using Gorevcim.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Services.Services
{
    public class ProductMeasurementService : GenericService<ProductMeasurementUnit>, IProductMeasurementUnitService
    {
        public ProductMeasurementService(IGenericRepository<ProductMeasurementUnit> repository, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
