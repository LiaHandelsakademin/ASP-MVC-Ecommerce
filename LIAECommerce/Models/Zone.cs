using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Zone
    {
        public int zone_id { get; set; }
        public int country_id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public short status { get; set; }
    }
}
