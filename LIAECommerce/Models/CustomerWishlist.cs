using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerWishlist
    {
        public int customer_id { get; set; }
        public int product_id { get; set; }
        public DateTime date_added { get; set; }
    }
}
