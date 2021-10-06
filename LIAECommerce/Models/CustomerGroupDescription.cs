using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerGroupDescription
    {
        public int CustomerGroupId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
