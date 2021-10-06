using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class TaxRate
    {
        public int TaxRateId { get; set; }
        public int GeoZoneId { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string Type { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

    }
}
