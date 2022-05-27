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
    public class ProductProjectController : CustomBaseController
    {
        private readonly IProductProjectService _productProjectService;
        private readonly IMapper _mapper;

        public ProductProjectController(IProductProjectService productProjectService, IMapper mapper)
        {
            _productProjectService = productProjectService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ProjectGetAll()
        {
            var project = await _productProjectService.GetAllAsync();
            var projectDtos = _mapper.Map<List<ProductProjectDto>>(project.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductProjectDto>>.Success(200, projectDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ProjectGetById(int id)
        {
            var project = await _productProjectService.GetByIdAsync(id);
            var projectDtos = _mapper.Map<ProductProjectDto>(project);
            return CreateActionResult(CustomResponseDto<ProductProjectDto>.Success(200, projectDtos));
        }        
        [HttpDelete]
        public async Task<IActionResult> ProjectDelete(int projectId)
        {
            var project = await _productProjectService.GetByIdAsync(projectId);
            await _productProjectService.RemoveAsync(project);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpPost]
        public async Task<IActionResult> ProjectAdd(ProductProjectDto productProjectDto)
        {
            var project = await _productProjectService.AddAsync(_mapper.Map<ProductProject>(productProjectDto));
            var projectsDto = _mapper.Map<ProductProjectDto>(project);
            return CreateActionResult(CustomResponseDto<ProductProjectDto>.Success(200, projectsDto));
        }
        [HttpPut]
        public async Task<IActionResult> ProjectUpdate(ProductProjectDto productProjectDto)
        {
            await _productProjectService.UpdateAsync(_mapper.Map<ProductProject>(productProjectDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
