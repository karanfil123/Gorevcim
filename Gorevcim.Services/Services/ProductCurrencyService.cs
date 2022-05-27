using Gorevcim.Core;
using Gorevcim.Core.Services;
using Gorevcim.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Services.Services
{
    public class ProductCurrencyService : GenericService<ProductCurrencyUnit>, IProductCurrencyService
    {
        public ProductCurrencyService(Core.Repositories.IGenericRepository<ProductCurrencyUnit> repository, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
