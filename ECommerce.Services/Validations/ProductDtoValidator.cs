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
    public class ProductDtoValidator:AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.SalePrice).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} 0 dan biyük olması gerekiyor");
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} KategoriId 0 olamaz.");
        }

    }
}
