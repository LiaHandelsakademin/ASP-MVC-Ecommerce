using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Attribute
    {
        public int AttributeId { get; set; }
        public int AttributeGroupId { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
        public int SortOrder { get; set; }
    }
}
