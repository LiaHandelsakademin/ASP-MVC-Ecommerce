using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductDiscount
    {
        public int product_discount_id { get; set; }
        public int product_id { get; set; }
        public int customer_group_id { get; set; }
        public int quantity { get; set; }
        public int priority { get; set; }
        public decimal price { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }
    }
}
