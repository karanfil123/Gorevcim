using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Dtos
{
    public class ProductColorDto:BaseDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string ColorBase64Content { get; set; }
        public string ColorFileName { get; set; }
        public string ColorFilepath { get; set; }
        public string Explanation { get; set; }
        public int ProductFeaturesId { get; set; }
    }
}
