using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerGroupDescription
    {
        public int customer_group_id { get; set; }
        public int language_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
