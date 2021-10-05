using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class TaxRule
    {
        public int tax_rule_id { get; set; }
        public int tax_class_id { get; set; }
        public int tax_rate_id { get; set; }
        public string based { get; set; }
        public int priority { get; set; }
    }
}
