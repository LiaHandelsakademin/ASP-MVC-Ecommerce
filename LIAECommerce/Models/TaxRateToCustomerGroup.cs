using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class TaxRateToCustomerGroup
    {
        public int TaxRateId { get; set; }
        public TaxRate TaxRate { get; set; }
        public int CustomerGroupId { get; set; }
        public CustomerGroup CustomerGroup { get; set; }
    }
}
