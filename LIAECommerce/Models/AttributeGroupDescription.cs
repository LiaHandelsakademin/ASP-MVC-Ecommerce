using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class AttributeGroupDescription
    {
        public int AttributeGroupId { get; set; }
        public AttributeGroup MyProperty { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
