using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Dtos
{
    public class CategoryProductDto:CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
