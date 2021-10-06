using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class OrderTotal
    {
        public int OrderTotalId { get; set; }
        public int OrderId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public int SortOrder { get; set; }
    }
}
