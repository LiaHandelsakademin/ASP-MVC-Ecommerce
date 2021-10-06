using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class OrderShipment
    {
        public int order_shipment_id { get; set; }
        public int OrderId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Shipping_courier_id { get; set; }
        public string tracking_number { get; set; }
    }
}
