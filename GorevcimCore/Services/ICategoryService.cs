using Gorevcim.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface ICategoryService:IGenericService<Category>
    {
        public Task<CustomResponseDto<CategoryProductDto>> GetCategoryIdProductAsync(int categoryId);
    }
}
