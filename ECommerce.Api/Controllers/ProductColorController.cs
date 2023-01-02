using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductColorController : CustomBaseController
    {
        private readonly IProductColorService _productColorService;
        private readonly IMapper _mapper;

        public ProductColorController(IProductColorService productColorService, IMapper mapper)
        {
            _productColorService = productColorService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ProductColorGetAll()
        {
            var color = await _productColorService.GetAllAsync();
            var colorDtos = _mapper.Map<List<ProductColorDto>>(color.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductColorDto>>.Success(200, colorDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ProductColorGetById(int id)
        {
            var color = await _productColorService.GetByIdAsync(id);
            var colorDto = _mapper.Map<ProductColorDto>(color);
            return CreateActionResult(CustomResponseDto<ProductColorDto>.Success(200, colorDto));
        }

        [HttpDelete]
        public async Task<IActionResult> ProductColorDelete(int colorId)
        {
            var color = await _productColorService.GetByIdAsync(colorId);
            await _productColorService.RemoveAsync(color);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpPost]
        public async Task<IActionResult> ProductColorAdd(ProductColorDto productColorDto)
        {
            var color = await _productColorService.AddAsync(_mapper.Map<ProductsColor>(productColorDto));
            var colorDto = _mapper.Map<ProductsColor>(color);
            return CreateActionResult(CustomResponseDto<ProductsColor>.Success(200, colorDto));
        }
        [HttpPut]
        public async Task<IActionResult> ProductColorUpdate(ProductColorDto productColorDto)
        {
            await _productColorService.UpdateAsync(_mapper.Map<ProductsColor>(productColorDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
