using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductAttribute
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Text { get; set; }
    }
}
