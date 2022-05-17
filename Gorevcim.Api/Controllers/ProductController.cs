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
        private readonly IMapper _mapper;
        //Controller sadece servislere erişebilmelidir.
        private readonly IGenericService<Product> _service;

        public ProductController(IMapper mapper, IGenericService<Product> service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var product = await _service.GetAllAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(product.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            var productDtos = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDtos));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
                       
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            var products = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(products);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

    }
}
