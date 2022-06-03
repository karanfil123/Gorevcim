using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Web.Controllers
{
    public class ProductColorController : Controller
    {
        private readonly IProductColorService _productColorService;
        private readonly IMapper _mapper;

        public ProductColorController(IProductColorService productColorService, IMapper mapper)
        {
            _productColorService = productColorService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var color=await _productColorService.GetAllAsync();
            var colorDto=_mapper.Map<List<ProductColorDto>>(color.ToList());
            return View(colorDto);
        }
        public async Task<IActionResult> ColorDelete(int id)
        {
            var color = await _productColorService.GetByIdAsync(id);
            await _productColorService.RemoveAsync(color);
            return RedirectToAction("Index", "ProductColor");
        }
        public async Task<IActionResult> ColorSave()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ColorSave(ProductColorDto productColorDto)
        {
            if (ModelState.IsValid)
            {
                var color = _mapper.Map<ProductsColor>(productColorDto);
                await _productColorService.AddAsync(color);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
