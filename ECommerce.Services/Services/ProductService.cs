﻿using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.Services;
using Gorevcim.Core.UnitOfWork;

namespace Gorevcim.Services.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private readonly IProductRepository _producRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IGenericUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _producRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductCategoryDto>> GetAllWebProductCategories()
        {
           var products = await _producRepository.GetAllWebProductsCategory();
            var productsDto=_mapper.Map<List<ProductCategoryDto>>(products);
            return productsDto.ToList();
        }   
        public async Task<CustomResponseDto<List<ProductCategoryDto>>> GetProductsCategory()
        {
            var products = await _producRepository.GetAllWebProductsCategory();
            var productDtos = _mapper.Map<List<ProductCategoryDto>>(products);
            return CustomResponseDto<List<ProductCategoryDto>>.Success(200, productDtos);
        }
    }
}
