using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderTotal
    {
        public int order_total_id { get; set; }
        public int OrderId { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public decimal value { get; set; }
        public int SortOrder { get; set; }
    }
}
