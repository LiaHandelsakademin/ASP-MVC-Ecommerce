using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomFieldValueDescription
    {
        public int custom_field_value_id { get; set; }
        public int language_id { get; set; }
        public int custom_field_id { get; set; }
        public string name { get; set; }
    }
}
