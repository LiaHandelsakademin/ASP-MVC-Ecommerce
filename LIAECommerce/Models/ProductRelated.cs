using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductRelated
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int RelatedId { get; set; }
    }
}
