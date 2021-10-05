using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductAttribute
    {
        public int product_id { get; set; }
        public int attribute_id { get; set; }
        public int language_id { get; set; }
        public string text { get; set; }
    }
}
