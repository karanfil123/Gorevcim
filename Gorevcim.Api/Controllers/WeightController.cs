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
    public class WeightController : CustomBaseController
    {
        private readonly IProductWeightUnitService _productWeightUnitService;
        private readonly IMapper _mapper;

        public WeightController(IProductWeightUnitService productWeightUnitService, IMapper mapper)
        {
            _productWeightUnitService = productWeightUnitService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> WeightGetAll()
        {
            var weight = await _productWeightUnitService.GetAllAsync();
            var weightDtos = _mapper.Map<List<ProductWeightUnitDto>>(weight.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductWeightUnitDto>>.Success(200, weightDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> WeightGetById(int id)
        {
            var weight = await _productWeightUnitService.GetByIdAsync(id);
            var weightDtos = _mapper.Map<ProductWeightUnitDto>(weight);
            return CreateActionResult(CustomResponseDto<ProductWeightUnitDto>.Success(200, weightDtos));
        }
        [HttpDelete]
        public async Task<IActionResult> WeightDelete(int weightId)
        {
            var weight = await _productWeightUnitService.GetByIdAsync(weightId);
            await _productWeightUnitService.RemoveAsync(weight);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpPost]
        public async Task<IActionResult> WeightAdd(ProductWeightUnitDto productWeightUnitDto)
        {
            var weight = await _productWeightUnitService.AddAsync(_mapper.Map<ProductsWeightUnit>(productWeightUnitDto));
            var weightDtos = _mapper.Map<ProductWeightUnitDto>(weight);
            return CreateActionResult(CustomResponseDto<ProductWeightUnitDto>.Success(200, weightDtos));
        }
        [HttpPut]
        public async Task<IActionResult> WeightUpdate(ProductWeightUnitDto productWeightUnitDto)
        {
            await _productWeightUnitService.UpdateAsync(_mapper.Map<ProductsWeightUnit>(productWeightUnitDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
