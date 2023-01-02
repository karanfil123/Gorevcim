using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class Company:BaseEntity
    {
        public int CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string WebUrl { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
