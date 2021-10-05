using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Recurring
    {
        public int recurring_id { get; set; }
        public decimal price { get; set; }
        public string frequency { get; set; }
        public long duration { get; set; }
        public long cycle { get; set; }
        public short trial_status { get; set; }
        public decimal trial_price { get; set; }
        public string trial_frequency { get; set; }
        public long trial_duration { get; set; }
        public long trial_cycle { get; set; }
        public short status { get; set; }
        public int sort_order { get; set; }
    }
}
