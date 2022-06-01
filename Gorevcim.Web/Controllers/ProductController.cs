using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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

        [HttpGet]
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
       
        [HttpPost]
        public async Task<IActionResult> ProductSave(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                await _productService.AddAsync(_mapper.Map<Product>(productDto));
                return RedirectToAction(nameof(Index));
              

            }
         return View(productDto);   
        }
    }
}
