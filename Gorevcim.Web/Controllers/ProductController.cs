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
        private char term;

        public ProductsController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllWebProductCategories();            
            return View(result);
        }

        public async Task<IActionResult> ProductDelete(int id)
        {
            var products = await _productService.GetByIdAsync(id);
            await _productService.RemoveAsync(products);
            TempData.Add("Success", "Ürün silindi.");
            return RedirectToAction("Index", "Products");
        }       

        public async Task<IActionResult> ProductSave()
        {
            var categoriess = await _categoryService.GetAllAsync();
            var data = categoriess.Where(a => a.Name.Contains(term, StringComparison.OrdinalIgnoreCase)
            || a.Name.Contains(term, StringComparison.OrdinalIgnoreCase)
            || a.Name.Contains(term, StringComparison.OrdinalIgnoreCase)).ToList().AsReadOnly();

            var categories=await _categoryService.GetAllAsync();
            ViewBag.categories = new SelectList(categoriess, "Id", "Name");



            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ProductSave(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(productDto);
                await _productService.AddAsync(product);
                TempData.Add("Success", "Ürün başarıyka eklendi.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Ürün eklenirken hata oluştu. => Product|ProductSave|53");
            var categories=await _categoryService.GetAllAsync();
            var categoriesDto=_mapper.Map<List<CategoryDto>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");
            return View(productDto);
        }
        public async Task<IActionResult> ProductUpdate(int id)
        {
            var products=await _productService.GetByIdAsync(id);
            var categories = await _categoryService.GetAllAsync();
            var categoryDto=_mapper.Map<List<CategoryDto>>(categories.ToList());
            ViewBag.categories = new SelectList(categories, "Id", "Name",products.CategoryId);
            return View(_mapper.Map<ProductDto>(products));
        }
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(productDto);
                await _productService.UpdateAsync(product);
                TempData.Add("Success", "Ürün başarıyka güncellendi.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Ürün eklenirken hata oluştu. => Product|ProductUpdate|76. satır");
            var categories = await _categoryService.GetAllAsync();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");
            return View(productDto);
        }


    }
}
