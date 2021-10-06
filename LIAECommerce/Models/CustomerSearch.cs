using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerSearch
    {
        public int CustomerSearchId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public int CustomerId { get; set; }
        public string Keyword { get; set; }
        public int? CategoryId { get; set; }
        public short SubCategory { get; set; }
        public short Description { get; set; }
        public int Products { get; set; }
        //public string ip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
