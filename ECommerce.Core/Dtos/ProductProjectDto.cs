﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Dtos
{
    public class ProductProjectDto:BaseDto
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public int ProductFeaturesId { get; set; }

    }
}
