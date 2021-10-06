using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerHistory
    {
        public int CustomerHistoryId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
