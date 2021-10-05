using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Category
    {
        public int category_id { get; set; }
        public string image { get; set; }
        public int parent_id { get; set; }
        public short top { get; set; }
        public int column { get; set; }
        public int sort_order { get; set; }
        public short status { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
