using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductOption
    {
        public int product_option_id { get; set; }
        public int product_id { get; set; }
        public int option_id { get; set; }
        public string value { get; set; }
        public short required { get; set; }
    }
}
