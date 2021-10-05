using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Location
    {
        public int location_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string geocode { get; set; }
        public string image { get; set; }
        public string open { get; set; }
        public string comment { get; set; }
    }
}
