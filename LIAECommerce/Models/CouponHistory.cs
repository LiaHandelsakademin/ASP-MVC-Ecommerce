using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CouponHistory
    {
        public int CouponHistoryId { get; set; }
        public int CouponId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
