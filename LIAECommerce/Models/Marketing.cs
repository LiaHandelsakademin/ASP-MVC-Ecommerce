using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Marketing
    {
        public int marketing_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public int clicks { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
