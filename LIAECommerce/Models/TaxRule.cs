using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class TaxRule
    {
        public int TaxRuleId { get; set; }
        public int TaxClassId { get; set; }
        public int TaxRateId { get; set; }
        public string Based { get; set; }
        public int Priority { get; set; }
    }
}
