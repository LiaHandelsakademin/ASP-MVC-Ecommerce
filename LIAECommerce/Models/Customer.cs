using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Customer
    {
        public int customer_id { get; set; }
        public int customer_group_id { get; set; }
        public int store_id { get; set; }
        public int language_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string cart { get; set; }
        public string wishlist { get; set; }
        public short newsletter { get; set; }
        public int address_id { get; set; }
        public string custom_field { get; set; }
        public string ip { get; set; }
        public short status { get; set; }
        public short safe { get; set; }
        public string token { get; set; }
        public string code { get; set; }
        public DateTime date_added { get; set; }
    }
}
