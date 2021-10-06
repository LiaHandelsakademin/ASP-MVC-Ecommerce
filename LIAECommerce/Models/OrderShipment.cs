using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class OrderShipment
    {
        public int OrderShipmentId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateAdded { get; set; }
        public string ShippingCourierId { get; set; }
        public string TrackingNumber { get; set; }
    }
}
