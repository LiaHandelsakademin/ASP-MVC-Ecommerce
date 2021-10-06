using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class Marketing
    {
        public int MarketingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Clicks { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
