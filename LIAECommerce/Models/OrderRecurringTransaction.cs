using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderRecurringTransaction
    {
        public int order_recurring_transaction_id { get; set; }
        public int order_recurring_id { get; set; }
        public string reference { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public DateTime date_added { get; set; }
    }
}
