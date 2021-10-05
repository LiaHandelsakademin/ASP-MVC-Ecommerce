using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Theme
    {
        public int theme_id { get; set; }
        public int store_id { get; set; }
        public string theme { get; set; }
        public string route { get; set; }
        public string code { get; set; }
        public DateTime date_added { get; set; }
    }
}
