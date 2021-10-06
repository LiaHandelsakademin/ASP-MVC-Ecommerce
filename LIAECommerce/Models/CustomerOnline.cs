using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerOnline
    {
        //public string ip { get; set; }
        public int CustomerId { get; set; }
        public string Url { get; set; }
        public string Referer { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
