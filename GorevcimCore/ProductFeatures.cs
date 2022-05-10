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
        public ProductsBrand ProductsBrand { get; set; }
        public int ProductsColorId { get; set; }
        public ProductsColor ProductsColor { get; set; }
        public int ProductCurrencyUnitId { get; set; }
        public ProductCurrencyUnit ProductCurrencyUnit { get; set; }
        public int ProductMeasurementId { get; set; }
        public ProductMeasurementUnit ProductMeasurementUnit { get; set; }
        public int ProductWeightUnitsId { get; set; }
        public ProductsWeightUnit ProductsWeightUnit { get; set; }
       
    }
}
