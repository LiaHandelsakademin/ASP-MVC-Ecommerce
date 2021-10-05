using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CouponHistory
    {
        public int coupon_history_id { get; set; }
        public int coupon_id { get; set; }
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public decimal amount { get; set; }
        public DateTime date_added { get; set; }
    }
}
