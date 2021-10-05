using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductDiscount
    {
        public int ProductDiscountId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerGroupId { get; set; }
        public CustomerGroup CustomerGroup { get; set; }
        public int Quantity { get; set; }
        public int Priority { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
