using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Review
    {
        public int review_id { get; set; }
        public int product_id { get; set; }
        public int customer_id { get; set; }
        public string author { get; set; }
        public string text { get; set; }
        public int rating { get; set; }
        public short status { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
