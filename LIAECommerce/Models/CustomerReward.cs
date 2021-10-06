using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerReward
    {
        public int CustomerRewardId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
