using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class GeoZone
    {
        public int geo_zone_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
