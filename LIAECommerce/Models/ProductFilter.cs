using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductFilter
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int FilterId { get; set; }
        public Filter Filter { get; set; }
    }
}
