using AutoMapper;
using Gorevcim.Services.Services;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using Gorevcim.Core.Services;

namespace Gorevcim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        //Mapping işlemi 
        //Controller sadece servislere erişebilmelidir.
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductCategories()
        {
            return CreateActionResult(await _productService.GetProductsCategory());
        }

        [HttpGet]
        public async Task<IActionResult> ProductGetAll()
        {
            var product = await _productService.GetAllAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(product.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ProductGetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var productDtos = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDtos));
        }

        [HttpPost]
        public async Task<IActionResult> ProductSave(ProductDto productDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(productDto));

            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDto));
        }

        [HttpPut]
        public async Task<IActionResult> ProductUpdate(ProductDto productDto)
        {
            await _productService.UpdateAsync(_mapper.Map<Product>(productDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete]
        public async Task<IActionResult> ProductRemove(int id)
        {
            var products = await _productService.GetByIdAsync(id);
            await _productService.RemoveAsync(products);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

    }
}
