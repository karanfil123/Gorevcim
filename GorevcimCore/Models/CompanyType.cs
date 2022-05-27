using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class CompanyType:BaseEntity
    {
        public string TypeName { get; set; }
        public ICollection<Company> Companies { get; set; }

    }
}
