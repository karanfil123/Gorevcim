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
    public class ProductFeatureController : CustomBaseController
    {
        private readonly IProductFeaturesService _productFeaturesService;
        private readonly IMapper _mapper;

        public ProductFeatureController(IProductFeaturesService productFeaturesService, IMapper mapper)
        {
            _productFeaturesService = productFeaturesService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ProductFeatureGetAll()
        {
            var feature = await _productFeaturesService.GetAllAsync();
            var featureDtos = _mapper.Map<List<ProductFeaturesDto>>(feature.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductFeaturesDto>>.Success(200, featureDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ProductFeatureGetById(int id)
        {
            var fea = await _productFeaturesService.GetByIdAsync(id);
            var feaDto = _mapper.Map<ProductFeaturesDto>(fea);
            return CreateActionResult(CustomResponseDto<ProductFeaturesDto>.Success(200, feaDto));
        }


        [HttpDelete]
        public async Task<IActionResult> ProductFeatureDelete(int vatId)
        {
            var fea = await _productFeaturesService.GetByIdAsync(vatId);
            await _productFeaturesService.RemoveAsync(fea);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpPost]
        public async Task<IActionResult> ProductFeatureAdd(ProductFeaturesDto productFeaturesDto)
        {
            var fea = await _productFeaturesService.AddAsync(_mapper.Map<ProductFeatures>(productFeaturesDto));
            var feasDto = _mapper.Map<ProductFeaturesDto>(fea);
            return CreateActionResult(CustomResponseDto<ProductFeaturesDto>.Success(200, feasDto));
        }
        [HttpPut]
        public async Task<IActionResult> ProductFeatureUpdate(ProductFeaturesDto productFeaturesDto)
        {
            await _productFeaturesService.UpdateAsync(_mapper.Map<ProductFeatures>(productFeaturesDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
