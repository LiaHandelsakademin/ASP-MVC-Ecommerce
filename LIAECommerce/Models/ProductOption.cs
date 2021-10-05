using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductOption
    {
        public int ProductOptionId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public ICollection<ProductOptionValue> ProductOptionValues { get; set; }
        public ICollection<OrderOption> OrderOptions { get; set; }
        public string Value { get; set; }
        public short Required { get; set; }
    }
}
