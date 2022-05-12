using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core
{
    public  class ProductCurrencyUnit:BaseEntity
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Explanation { get; set; }
        public int ProductFeaturesId { get; set; }
        public ProductFeatures ProductFeatures { get; set; }
    }
}
