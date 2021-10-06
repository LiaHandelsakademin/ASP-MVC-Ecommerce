using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomFieldCustomerGroup
    {
        public int CustomFieldId { get; set; }
        public int CustomerGroupId { get; set; }
        public short Required { get; set; }
    }
}
