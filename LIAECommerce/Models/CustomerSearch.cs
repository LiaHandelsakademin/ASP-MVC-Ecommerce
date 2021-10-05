using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerSearch
    {
        public int customer_search_id { get; set; }
        public int store_id { get; set; }
        public int language_id { get; set; }
        public int customer_id { get; set; }
        public string keyword { get; set; }
        public int? category_id { get; set; }
        public short sub_category { get; set; }
        public short description { get; set; }
        public int products { get; set; }
        public string ip { get; set; }
        public DateTime date_added { get; set; }
    }
}
