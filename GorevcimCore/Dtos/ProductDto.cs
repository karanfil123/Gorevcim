using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Dtos
{
    public class ProductDto:BaseDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Explanation { get; set; }
        public string Barcode { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsActive { get; set; }=true;
        public string TechnicalWebUrl { get; set; }
        public string ExplanationWebUrl { get; set; }
    }
}
