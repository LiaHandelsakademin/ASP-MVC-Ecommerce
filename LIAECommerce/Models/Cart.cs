using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Cart
    {
        public long cart_id { get; set; }
        public int api_id { get; set; }
        public int customer_id { get; set; }
        public string session_id { get; set; }
        public int product_id { get; set; }
        public int recurring_id { get; set; }
        public string option { get; set; }
        public int quantity { get; set; }
        public DateTime date_added { get; set; }
    }
}
