using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerOnline
    {
        public string ip { get; set; }
        public int customer_id { get; set; }
        public string url { get; set; }
        public string referer { get; set; }
        public DateTime date_added { get; set; }
    }
}
