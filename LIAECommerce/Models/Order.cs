using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LIAECommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        //public int CustomerId { get; set; }
        public DateTime ShippingDate { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
