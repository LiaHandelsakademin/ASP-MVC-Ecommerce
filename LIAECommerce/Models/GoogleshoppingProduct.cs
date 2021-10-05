using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class GoogleshoppingProduct
    {
        public long product_advertise_google_id { get; set; }
        public int? product_id { get; set; }
        public int store_id { get; set; }
        public short? has_issues { get; set; }
        public string destination_status { get; set; }
        public int impressions { get; set; }
        public int clicks { get; set; }
        public int conversions { get; set; }
        public decimal cost { get; set; }
        public decimal conversion_value { get; set; }
        public string google_product_category { get; set; }
        public string condition { get; set; }
        public short? adult { get; set; }
        public int? multipack { get; set; }
        public short? is_bundle { get; set; }
        public string age_group { get; set; }
        public int? color { get; set; }
        public string gender { get; set; }
        public string size_type { get; set; }
        public string size_system { get; set; }
        public int? size { get; set; }
        public short is_modified { get; set; }
    }
}
