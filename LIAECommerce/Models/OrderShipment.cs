using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderShipment
    {
        public int order_shipment_id { get; set; }
        public int order_id { get; set; }
        public DateTime date_added { get; set; }
        public string shipping_courier_id { get; set; }
        public string tracking_number { get; set; }
    }
}
