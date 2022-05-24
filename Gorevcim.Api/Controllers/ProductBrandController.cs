using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Services;
using Gorevcim.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductBrandController : CustomBaseController
    {
        private readonly IProductBrandService _productBrandService;
        private readonly IMapper _mapper;

        public ProductBrandController(IProductBrandService productBrandService, IMapper mapper)
        {
            _productBrandService = productBrandService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ProductBrandGetAll()
        {
            var brand = await _productBrandService.GetAllAsync();
            var brandDtos = _mapper.Map<List<ProductBrandDto>>(brand.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductBrandDto>>.Success(200, brandDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ProductBrandGetById(int id)
        {
            var brand = await _productBrandService.GetByIdAsync(id);
            var brandDto = _mapper.Map<ProductBrandDto>(brand);
            return CreateActionResult(CustomResponseDto<ProductBrandDto>.Success(200, brandDto));
        }

       
        [HttpDelete]
        public async Task<IActionResult> ProductBrandDelete(int brandId)
        {
            var brand = await _productBrandService.GetByIdAsync(brandId);
            await _productBrandService.RemoveAsync(brand);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpPost]
        public async Task<IActionResult> ProductBrandAdd(ProductBrandDto productBrandDto)
        {
            var brand = await _productBrandService.AddAsync(_mapper.Map<ProductsBrand>(productBrandDto));
            var brandsDto = _mapper.Map<ProductBrandDto>(brand);
            return CreateActionResult(CustomResponseDto<ProductBrandDto>.Success(200, brandsDto));
        }
        [HttpPut]
        public async Task<IActionResult> ProductBrandUpdate(ProductBrandDto productBrandDto)
        {
            await _productBrandService.UpdateAsync(_mapper.Map<ProductsBrand>(productBrandDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
