using FluentValidation;
using Gorevcim.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Services.Validations
{
    public class CategoryDtoValidator:AbstractValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
        }
        
    }
}
