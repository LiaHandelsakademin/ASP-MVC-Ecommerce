using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerLogin
    {
        public int customer_login_id { get; set; }
        public string email { get; set; }
        public string ip { get; set; }
        public int total { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
