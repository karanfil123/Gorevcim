using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Web.Controllers
{
    public class ProductBrandController : Controller
    {
        private readonly IProductBrandService _productBrandService;
        private readonly IMapper _mapper;

        public ProductBrandController(IProductBrandService productBrandService, IMapper mapper)
        {
            _productBrandService = productBrandService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var brand=await _productBrandService.GetAllAsync();
            var brandDto = _mapper.Map<List<ProductBrandDto>>(brand.ToList());
            return View(brandDto);
        }     
        public async Task<IActionResult> BrandDelete(int id)
        {
            var category = await _productBrandService.GetByIdAsync(id);
            await _productBrandService.RemoveAsync(category);
            return RedirectToAction("Index", "ProductBrand");
        }
        public IActionResult BrandSave()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BrandSave(ProductBrandDto productBrandDto)
        {
            if (ModelState.IsValid)
            {
                var category = _mapper.Map<ProductsBrand>(productBrandDto);
                await _productBrandService.AddAsync(category);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    }
}
