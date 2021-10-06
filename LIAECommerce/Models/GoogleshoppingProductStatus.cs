using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class GoogleshoppingProductStatus
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string product_variation_id { get; set; }
        public string destination_Statuses { get; set; }
        public string data_quality_issues { get; set; }
        public string item_level_issues { get; set; }
        public int google_expiration_date { get; set; }
    }
}
