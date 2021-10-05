using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerReward
    {
        public int customer_reward_id { get; set; }
        public int customer_id { get; set; }
        public int order_id { get; set; }
        public string description { get; set; }
        public int points { get; set; }
        public DateTime date_added { get; set; }
    }
}
