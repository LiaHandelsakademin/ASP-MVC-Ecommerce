using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Coupon
    {
        public int coupon_id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public decimal discount { get; set; }
        public short logged { get; set; }
        public short shipping { get; set; }
        public decimal total { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }
        public int uses_total { get; set; }
        public string uses_customer { get; set; }
        public short status { get; set; }
        public DateTime date_added { get; set; }
    }
}
