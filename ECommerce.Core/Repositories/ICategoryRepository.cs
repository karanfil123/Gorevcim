﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<Category> GetWebCategoryByIdProductsAsync(int categoryId);
        Task<List<Category>> GetWebCategoryProductsAsync();
      
    }
}
