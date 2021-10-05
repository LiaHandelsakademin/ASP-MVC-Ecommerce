using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Translation
    {
        public int translation_id { get; set; }
        public int store_id { get; set; }
        public int language_id { get; set; }
        public string route { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        public DateTime date_added { get; set; }
    }
}
