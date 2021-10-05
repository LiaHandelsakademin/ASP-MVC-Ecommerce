using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerIp
    {
        public int customer_ip_id { get; set; }
        public int customer_id { get; set; }
        public string ip { get; set; }
        public DateTime date_added { get; set; }
    }
}
