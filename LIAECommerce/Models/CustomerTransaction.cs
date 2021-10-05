using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerTransaction
    {
        public int customer_transaction_id { get; set; }
        public int customer_id { get; set; }
        public int order_id { get; set; }
        public string description { get; set; }
        public decimal amount { get; set; }
        public DateTime date_added { get; set; }
    }
}
