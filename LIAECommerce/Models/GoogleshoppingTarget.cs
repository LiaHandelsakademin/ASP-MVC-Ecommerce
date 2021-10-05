using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class GoogleshoppingTarget
    {
        public long advertise_google_target_id { get; set; }
        public int store_id { get; set; }
        public string campaign_name { get; set; }
        public string country { get; set; }
        public decimal budget { get; set; }
        public string feeds { get; set; }
        public string status { get; set; }
        public DateTime? date_added { get; set; }
        public int roas { get; set; }
    }
}
