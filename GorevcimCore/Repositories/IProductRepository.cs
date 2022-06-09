using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<Product> GetWebProductByIdCategory(int productId);
        Task<List<Product>> GetAllWebProductsCategory();
       

    }
}
