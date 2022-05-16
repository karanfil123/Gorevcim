using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreateUserId  { get; set; }
        public DateTime UpdateDate  { get; set; }
        public int UpdateUserId  { get; set; }
        public bool IsActive  { get; set; }
        public DateTime IsActiveDate  { get; set; }
        public int IsActiveDateUserId  { get; set; }
        public DateTime IsActiveDateUpdate  { get; set; }
        public int IsActiveDateUpdateUserId  { get; set; }
        public bool IsDelete  { get; set; }
        public DateTime IsDeleteDate  { get; set; }       
        public int IsDeleteDateUserId  { get; set; }
        public DateTime IsDeleteDateUpdate { get; set; }
        public int IsDeleteUpdateUserId { get; set; }
    }
}
