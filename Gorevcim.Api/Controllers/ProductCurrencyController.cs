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
    public class ProductCurrencyController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IProductCurrencyService _productCurrencyService;

        public ProductCurrencyController(IMapper mapper, IProductCurrencyService productCurrencyService)
        {
            _mapper = mapper;
            _productCurrencyService = productCurrencyService;
        }
        [HttpGet]
        public async Task<IActionResult> ProductCurrencyGetAll()
        {
            var currency = await _productCurrencyService.GetAllAsync();
            var currencyDtos = _mapper.Map<List<ProductCurrencyUnitsDto>>(currency.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductCurrencyUnitsDto>>.Success(200, currencyDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ProductCurrencyGetById(int id)
        {
            var currency = await _productCurrencyService.GetByIdAsync(id);
            var currencyDto = _mapper.Map<ProductCurrencyUnitsDto>(currency);
            return CreateActionResult(CustomResponseDto<ProductCurrencyUnitsDto>.Success(200, currencyDto));
        }


        [HttpDelete]
        public async Task<IActionResult> ProductCurrencyDelete(int currenyId)
        {
            var currency = await _productCurrencyService.GetByIdAsync(currenyId);
            await _productCurrencyService.RemoveAsync(currency);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpPost]
        public async Task<IActionResult> ProductCurrencyAdd(ProductCurrencyUnitsDto productCurrencyUnitsDto)
        {
            var currency = await _productCurrencyService.AddAsync(_mapper.Map<ProductCurrencyUnit>(productCurrencyUnitsDto));
            var currencysDto = _mapper.Map<ProductCurrencyUnitsDto>(currency);
            return CreateActionResult(CustomResponseDto<ProductCurrencyUnitsDto>.Success(200, currencysDto));
        }
        [HttpPut]
        public async Task<IActionResult> ProductCurrencyUpdate(ProductCurrencyUnitsDto productCurrencyUnitsDto)
        {
            await _productCurrencyService.UpdateAsync(_mapper.Map<ProductCurrencyUnit>(productCurrencyUnitsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
