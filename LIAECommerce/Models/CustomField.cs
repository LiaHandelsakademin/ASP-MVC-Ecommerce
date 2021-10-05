using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomField
    {
        public int custom_field_id { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public string validation { get; set; }
        public string location { get; set; }
        public short status { get; set; }
        public int sort_order { get; set; }
    }
}
