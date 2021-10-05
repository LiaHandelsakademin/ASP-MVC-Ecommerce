using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomFieldCustomerGroup
    {
        public int custom_field_id { get; set; }
        public int customer_group_id { get; set; }
        public short required { get; set; }
    }
}
