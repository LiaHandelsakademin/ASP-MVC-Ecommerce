using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Manufacturer
    {
        public int manufacturer_id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int sort_order { get; set; }
    }
}
