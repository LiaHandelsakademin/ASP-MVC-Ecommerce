using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class TaxClass
    {
        public int tax_class_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
