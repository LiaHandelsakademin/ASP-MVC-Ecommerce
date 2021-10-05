using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductToLayout
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int LayoutId { get; set; }
        public Layout Layout { get; set; }
    }
}
