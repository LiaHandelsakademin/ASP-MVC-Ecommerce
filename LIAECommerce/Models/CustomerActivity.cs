using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerActivity
    {
        public int CustomerActivityId { get; set; }
        public int CustomerId { get; set; }
        public string Key { get; set; }
        public string Data { get; set; }
        //public string ip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
