using AutoMapper;
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
    }
}
