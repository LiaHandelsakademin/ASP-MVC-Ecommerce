using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderRecurring
    {
        public int order_RecurringId { get; set; }
        public int OrderId { get; set; }
        public string reference { get; set; }
        public int ProductId { get; set; }
        public string product_name { get; set; }
        public int product_Quantity { get; set; }
        public int RecurringId { get; set; }
        public string recurring_name { get; set; }
        public string recurring_description { get; set; }
        public string recurring_frequency { get; set; }
        public short recurring_cycle { get; set; }
        public short recurring_duration { get; set; }
        public decimal recurring_price { get; set; }
        public short trial { get; set; }
        public string trial_frequency { get; set; }
        public short trial_cycle { get; set; }
        public short trial_duration { get; set; }
        public decimal trial_price { get; set; }
        public short status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
