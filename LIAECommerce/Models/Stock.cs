using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LIAECommerce.Models
{
    public class Stock
    {
        [Key]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int Quantity { get; set; }
    }
}
