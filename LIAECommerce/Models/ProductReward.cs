using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductReward
    {
        public int ProductRewardId { get; set; }
        public int productId { get; set; }
        public int CustomerGroupId { get; set; }
        public int Points { get; set; }
    }
}
