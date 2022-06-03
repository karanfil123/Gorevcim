using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();         
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories.ToList());
            return View(categoryDtos);
        }
        public async Task<IActionResult> CategoryDelete(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            await _categoryService.RemoveAsync(category);
            return RedirectToAction("Index", "Category");
        }
        public async Task<IActionResult> CategorySave()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategorySave(CategoryDto categoryDto)
        {
            if (ModelState.IsValid)
            {
                var category = _mapper.Map<Category>(categoryDto);
                await _categoryService.AddAsync(category);
                return RedirectToAction(nameof(Index));
            }           
            return View();
        }


    }
}
