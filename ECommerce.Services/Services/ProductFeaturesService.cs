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
    public class ProductFeaturesService : GenericService<ProductFeatures>, IProductFeaturesService
    {
        public ProductFeaturesService(IGenericRepository<ProductFeatures> repository, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
