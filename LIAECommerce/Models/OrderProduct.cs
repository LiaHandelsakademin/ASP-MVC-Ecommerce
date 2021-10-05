using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderProduct
    {
        public int order_product_id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal total { get; set; }
        public decimal tax { get; set; }
        public int reward { get; set; }
    }
}
