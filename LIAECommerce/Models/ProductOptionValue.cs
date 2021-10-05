using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductOptionValue
    {
        public int ProductOptionValueId { get; set; }
        public int ProductOptionId { get; set; }
        public ProductOption ProductOption { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public int OptionValueId { get; set; }
        public OptionValue OptionValue { get; set; }
        public int Quantity { get; set; }
        public short Subtract { get; set; }
        public decimal Price { get; set; }
        public string PricePrefix { get; set; }
        public int Points { get; set; }
        public string PointsPrefix { get; set; }
        public decimal Weight { get; set; }
        public string WeightPrefix { get; set; }
    }
}