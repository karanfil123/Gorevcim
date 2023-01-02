using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMeasurementController : CustomBaseController
    {
        private readonly ProductMeasurementService _productMeasurementService;
        private readonly IMapper _mapper;

        public ProductMeasurementController(ProductMeasurementService productMeasurementService, IMapper mapper)
        {
            _productMeasurementService = productMeasurementService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ProductMeasurementGetAll()
        {
            var mea = await _productMeasurementService.GetAllAsync();
            var meaDtos = _mapper.Map<List<ProductMeasurementUnitsDto>>(mea.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductMeasurementUnitsDto>>.Success(200, meaDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ProductMeasurementGetById(int id)
        {
            var mea = await _productMeasurementService.GetByIdAsync(id);
            var meaDto = _mapper.Map<ProductMeasurementUnitsDto>(mea);
            return CreateActionResult(CustomResponseDto<ProductMeasurementUnitsDto>.Success(200, meaDto));
        }


        [HttpDelete]
        public async Task<IActionResult> ProductMeasurementDelete(int meaId)
        {
            var mea = await _productMeasurementService.GetByIdAsync(meaId);
            await _productMeasurementService.RemoveAsync(mea);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpPost]
        public async Task<IActionResult> ProductMeasurementAdd(ProductMeasurementUnitsDto productMeasurementUnitsDto)
        {
            var mea = await _productMeasurementService.AddAsync(_mapper.Map<ProductMeasurementUnit>(productMeasurementUnitsDto));
            var measDto = _mapper.Map<ProductMeasurementUnitsDto>(mea);
            return CreateActionResult(CustomResponseDto<ProductMeasurementUnitsDto>.Success(200, measDto));
        }
        [HttpPut]
        public async Task<IActionResult> ProductMeasurementtUpdate(ProductMeasurementUnitsDto productMeasurementUnitsDto)
        {
            await _productMeasurementService.UpdateAsync(_mapper.Map<ProductMeasurementUnit>(productMeasurementUnitsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
