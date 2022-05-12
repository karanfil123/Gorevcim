using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core
{
    public class ProductFeatures:BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ProductsBrand ProductsBrand { get; set; }
        public ProductsColor ProductsColor { get; set; }
        public ProductCurrencyUnit ProductCurrencyUnit { get; set; }
        public ProductMeasurementUnit ProductMeasurementUnit { get; set; }
        public ProductsWeightUnit ProductsWeightUnit { get; set; }
        public ProductVatUnit ProductVatUnit { get; set; }
        public ProductProject ProductProject { get; set; }

        //product tablosu ile diğer tablolar arasındaki ilişki bu tablo üzerinden oluyo

    }
}
