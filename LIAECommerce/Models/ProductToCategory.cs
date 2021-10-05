using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductToCategory
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
