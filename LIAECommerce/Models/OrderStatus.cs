using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
