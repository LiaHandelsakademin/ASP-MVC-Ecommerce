using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerHistory
    {
        public int customer_history_id { get; set; }
        public int customer_id { get; set; }
        public string comment { get; set; }
        public DateTime date_added { get; set; }
    }
}
