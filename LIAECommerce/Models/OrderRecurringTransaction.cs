using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderRecurringTransaction
    {
        public int order_recurring_transaction_id { get; set; }
        public int order_RecurringId { get; set; }
        public string reference { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
