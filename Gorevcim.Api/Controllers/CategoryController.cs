using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.Services;
using Gorevcim.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryGetAll()
        {
            var categories=await _categoryService.GetAllAsync();
            var productsDtos=_mapper.Map<List<CategoryDto>>(categories.ToList());
            return CreateActionResult(CustomResponseDto<List<CategoryDto>>.Success(200,productsDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> CategoryGetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var categoryDto=_mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(200,categoryDto));
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetCategoryIdProduct(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetCategoryIdProductAsync(categoryId));
        }
        [HttpDelete]
        public async Task<IActionResult> CategoryDelete(int categoryId)
        {
            var category=await _categoryService.GetByIdAsync(categoryId);
            await _categoryService.RemoveAsync(category);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAdd(CategoryDto categoryDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
            var categoriesDto = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(200, categoriesDto));
        }
        [HttpPut]
        public async Task<IActionResult> CategoryUpdate(CategoryDto categoryDto)
        {
            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
