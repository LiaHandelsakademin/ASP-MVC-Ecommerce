using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
