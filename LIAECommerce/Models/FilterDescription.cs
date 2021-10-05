using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class FilterDescription
    {
        public int filter_id { get; set; }
        public int language_id { get; set; }
        public int filter_group_id { get; set; }
        public string name { get; set; }
    }
}
