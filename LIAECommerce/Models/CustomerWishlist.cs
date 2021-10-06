using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerWishlist
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
