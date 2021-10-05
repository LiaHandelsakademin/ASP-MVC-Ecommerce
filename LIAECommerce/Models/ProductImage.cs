using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductImage
    {
        public int product_image_id { get; set; }
        public int product_id { get; set; }
        public string image { get; set; }
        public int sort_order { get; set; }
    }
}
