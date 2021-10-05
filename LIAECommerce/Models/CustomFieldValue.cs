using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomFieldValue
    {
        public int custom_field_value_id { get; set; }
        public int custom_field_id { get; set; }
        public int sort_order { get; set; }
    }
}
