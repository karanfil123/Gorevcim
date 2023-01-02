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
    public class ProductVatController : CustomBaseController
    {
        private readonly IProductVatUnitService _productVatUnitService;
        private readonly IMapper _mapper;

        public ProductVatController(IProductVatUnitService productVatUnitService, IMapper mapper)
        {
            _productVatUnitService = productVatUnitService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ProductVatGetAll()
        {
            var vat = await _productVatUnitService.GetAllAsync();
            var vatDtos = _mapper.Map<List<ProductVatUnitDto>>(vat.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductVatUnitDto>>.Success(200, vatDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ProductVatGetById(int id)
        {
            var vat = await _productVatUnitService.GetByIdAsync(id);
            var vatDto = _mapper.Map<ProductVatUnitDto>(vat);
            return CreateActionResult(CustomResponseDto<ProductVatUnitDto>.Success(200, vatDto));
        }


        [HttpDelete]
        public async Task<IActionResult> ProductVatDelete(int vatId)
        {
            var vat = await _productVatUnitService.GetByIdAsync(vatId);
            await _productVatUnitService.RemoveAsync(vat);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpPost]
        public async Task<IActionResult> ProductVatAdd(ProductVatUnitDto productVatUnitDto)
        {
            var vat = await _productVatUnitService.AddAsync(_mapper.Map<ProductVatUnit>(productVatUnitDto));
            var vatsDto = _mapper.Map<ProductVatUnitDto>(vat);
            return CreateActionResult(CustomResponseDto<ProductVatUnitDto>.Success(200, vatsDto));
        }
        [HttpPut]
        public async Task<IActionResult> ProductVatUpdate(ProductVatUnitDto productVatUnitDto)
        {
            await _productVatUnitService.UpdateAsync(_mapper.Map<ProductVatUnit>(productVatUnitDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
