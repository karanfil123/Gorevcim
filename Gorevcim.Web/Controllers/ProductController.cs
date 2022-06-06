using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Gorevcim.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetWebProductCategories();            
            return View(result);
        }

        public async Task<IActionResult> ProductDelete(int id)
        {
            var products = await _productService.GetByIdAsync(id);
            await _productService.RemoveAsync(products);
            return RedirectToAction("Index", "Products");
        }       

        public async Task<IActionResult> ProductSave()
        {
           var categories=await _categoryService.GetAllAsync();
            ViewBag.categories = new SelectList(categories, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ProductSave(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(productDto);
                await _productService.AddAsync(product);
                TempData.Add("Başarılı", "Ürün başarıyka eklendi.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Hata", "Ürün eklenirken hata oluştu. => Product|ProductSave|53");
            var categories=await _categoryService.GetAllAsync();
            var categoriesDto=_mapper.Map<List<CategoryDto>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");
            return View(productDto);
        }
     
    }
}
