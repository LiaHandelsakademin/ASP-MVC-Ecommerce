using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CouponProduct
    {
        public int CouponProductId { get; set; }
        public int CouponId { get; set; }
        public int ProductId { get; set; }
    }
}
