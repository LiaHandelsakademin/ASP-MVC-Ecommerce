using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductOptionValue
    {
        public int product_option_value_id { get; set; }
        public int product_option_id { get; set; }
        public int product_id { get; set; }
        public int option_id { get; set; }
        public int option_value_id { get; set; }
        public int quantity { get; set; }
        public short subtract { get; set; }
        public decimal price { get; set; }
        public string price_prefix { get; set; }
        public int points { get; set; }
        public string points_prefix { get; set; }
        public decimal weight { get; set; }
        public string weight_prefix { get; set; }
    }
}
