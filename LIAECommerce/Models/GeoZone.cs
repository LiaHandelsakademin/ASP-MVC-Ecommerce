using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class GeoZone
    {
        public int geo_zone_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
