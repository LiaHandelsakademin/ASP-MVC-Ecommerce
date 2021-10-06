using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderProduct
    {
        public int order_ProductId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public decimal total { get; set; }
        public decimal tax { get; set; }
        public int reward { get; set; }
    }
}
