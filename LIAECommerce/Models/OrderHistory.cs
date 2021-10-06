using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderHistory
    {
        public int order_history_id { get; set; }
        public int OrderId { get; set; }
        public int order_status_id { get; set; }
        public short notify { get; set; }
        public string comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
