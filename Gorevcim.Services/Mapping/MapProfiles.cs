using AutoMapper;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;

namespace Gorevcim.Services.Mapping
{
    public class MapProfiles : Profile
    {
        public MapProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductsBrand, ProductBrandDto>().ReverseMap();
            CreateMap<ProductFeatures, ProductFeaturesDto>().ReverseMap();
            CreateMap<ProductsColor, ProductColorDto>().ReverseMap();
            CreateMap<ProductCurrencyUnit, ProductCurrencyUnitsDto>().ReverseMap();
            CreateMap<ProductMeasurementUnit, ProductMeasurementUnitsDto>().ReverseMap();
            CreateMap<ProductProject, ProductProjectDto>().ReverseMap();
            CreateMap<ProductVatUnit, ProductVatUnitDto>().ReverseMap();
            CreateMap<ProductsWeightUnit, ProductWeightUnitDto>().ReverseMap();
            CreateMap<Product, ProductCategoryDto>();
            CreateMap<Category, CategoryProductDto>();
        }
    }
}
