using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OptionValue
    {
        public int option_value_id { get; set; }
        public int option_id { get; set; }
        public string image { get; set; }
        public int SortOrder { get; set; }
    }
}
