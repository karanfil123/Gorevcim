using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core
{
    public class ProductsBrand : BaseEntity
    {
        public string BrandsName { get; set; }
        public string BrandsWeUrl { get; set; }
        public string Explanation { get; set; }
        public string LogoBase64Content { get; set; }
        public string LogoFileName { get; set; }
        public string LogoFilePath { get; set; }

    }
}
