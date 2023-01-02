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
    public class ProductColorService : GenericService<ProductsColor>, IProductColorService
    {
        public ProductColorService(IGenericRepository<ProductsColor> repository, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
