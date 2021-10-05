using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Product
    {
        public int product_id { get; set; }
        public string model { get; set; }
        public string sku { get; set; }
        public string upc { get; set; }
        public string ean { get; set; }
        public string jan { get; set; }
        public string isbn { get; set; }
        public string mpn { get; set; }
        public string location { get; set; }
        public int quantity { get; set; }
        public int stock_status_id { get; set; }
        public string image { get; set; }
        public int manufacturer_id { get; set; }
        public short shipping { get; set; }
        public decimal price { get; set; }
        public int points { get; set; }
        public int tax_class_id { get; set; }
        public DateTime date_available { get; set; }
        public decimal weight { get; set; }
        public int weight_class_id { get; set; }
        public decimal length { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public int length_class_id { get; set; }
        public short subtract { get; set; }
        public int minimum { get; set; }
        public int sort_order { get; set; }
        public short status { get; set; }
        public int viewed { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
