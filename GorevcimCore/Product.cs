using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core
{
    public class Product:BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }      
        public string Name { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsMixture { get; set; }
        public string Explanation { get; set; }
        public string LogoBase64Content { get; set; }
        public string LogoFileName { get; set; }
        public string LogoFilePath { get; set; }
        public string TechnicalWebUrl { get; set; }
        public string ExplanationWebUrl { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public ProductFeatures ProductFeatures { get; set; }
    }
}
