using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OptionValueDescription
    {
        public int option_value_id { get; set; }
        public int LanguageId { get; set; }
        public int option_id { get; set; }
        public string name { get; set; }
    }
}
