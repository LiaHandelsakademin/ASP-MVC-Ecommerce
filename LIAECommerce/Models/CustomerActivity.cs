using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerActivity
    {
        public int customer_activity_id { get; set; }
        public int customer_id { get; set; }
        public string key { get; set; }
        public string data { get; set; }
        public string ip { get; set; }
        public DateTime date_added { get; set; }
    }
}
