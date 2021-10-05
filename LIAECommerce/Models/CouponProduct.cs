using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CouponProduct
    {
        public int coupon_product_id { get; set; }
        public int coupon_id { get; set; }
        public int product_id { get; set; }
    }
}
