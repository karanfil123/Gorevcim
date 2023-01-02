using FluentValidation;
using Gorevcim.Core;
using Gorevcim.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Services.Validations
{
    public class ProductBrandValidator:AbstractValidator<ProductBrandDto>
    {
        public ProductBrandValidator()
        {
            RuleFor(x => x.BrandsName).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.LogoBase64Content).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.LogoFileName).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.LogoFilePath).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");

        }       
    }
}
