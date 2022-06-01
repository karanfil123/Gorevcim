using AutoMapper;
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
       
    }
}
