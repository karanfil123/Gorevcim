using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class Customer:BaseEntity
    {
        
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
