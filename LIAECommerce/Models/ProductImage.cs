using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public int SortOrder { get; set; }
    }
}
