using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcCustomerOnline
    {
        public string Ip { get; set; }
        public int CustomerId { get; set; }
        public string Url { get; set; }
        public string Referer { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
