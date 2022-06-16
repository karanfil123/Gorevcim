using Gorevcim.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface IProductService:IGenericService<Product>
    {
        Task<CustomResponseDto<List<ProductCategoryDto>>> GetProductsCategory();
        Task<List<ProductCategoryDto>> GetAllWebProductCategories();     
    }
}
