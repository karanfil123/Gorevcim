using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
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
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> repository, IGenericUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryProductDto>> GetCategoryIdProductAsync(int categoryId)
        {
            var category = await _categoryRepository.GetCategoryIdProductAsync(categoryId);
            var categoryDto=_mapper.Map<CategoryProductDto>(category);
            return CustomResponseDto<CategoryProductDto>.Success(200, categoryDto);

        }
    }
}
