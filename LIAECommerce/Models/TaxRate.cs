using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class TaxRate
    {
        public int tax_rate_id { get; set; }
        public int geo_zone_id { get; set; }
        public string name { get; set; }
        public decimal rate { get; set; }
        public string type { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
