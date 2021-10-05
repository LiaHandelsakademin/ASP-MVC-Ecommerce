using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductDescription
    {
        public int product_id { get; set; }
        public int language_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tag { get; set; }
        public string meta_title { get; set; }
        public string meta_description { get; set; }
        public string meta_keyword { get; set; }
    }
}
