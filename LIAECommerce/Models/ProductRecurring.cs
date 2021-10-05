using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductRecurring
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int RecurringId { get; set; }
        public Recurring Recurring { get; set; }
        public int CustomerGroupId { get; set; }
        public CustomerGroup CustomerGroup { get; set; }
    }
}
