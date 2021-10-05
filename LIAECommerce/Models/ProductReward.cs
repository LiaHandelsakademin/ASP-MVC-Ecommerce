using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductReward
    {
        public int product_reward_id { get; set; }
        public int product_id { get; set; }
        public int customer_group_id { get; set; }
        public int points { get; set; }
    }
}
