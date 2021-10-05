using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Voucher
    {
        public int voucher_id { get; set; }
        public int order_id { get; set; }
        public string code { get; set; }
        public string from_name { get; set; }
        public string from_email { get; set; }
        public string to_name { get; set; }
        public string to_email { get; set; }
        public int voucher_theme_id { get; set; }
        public string message { get; set; }
        public decimal amount { get; set; }
        public short status { get; set; }
        public DateTime date_added { get; set; }
    }
}
