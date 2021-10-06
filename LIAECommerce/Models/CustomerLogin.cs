using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerLogin
    {
        public int CustomerLoginId { get; set; }
        public string Email { get; set; }
        //public string ip { get; set; }
        public int Total { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
