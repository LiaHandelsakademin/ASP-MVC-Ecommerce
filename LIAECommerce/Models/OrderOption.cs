using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderOption
    {
        public int order_option_id { get; set; }
        public int OrderId { get; set; }
        public int order_ProductId { get; set; }
        public int product_option_id { get; set; }
        public int product_option_value_id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string type { get; set; }
    }
}
