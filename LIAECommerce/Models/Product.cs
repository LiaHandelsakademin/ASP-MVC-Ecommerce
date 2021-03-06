using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Model { get; set; }
        public string SKU { get; set; }
        public string UPC { get; set; }
        public string EAN { get; set; }
        public string JAN { get; set; }
        public string ISBN { get; set; }
        public string MPN { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public int StockStatusId { get; set; }
        public string MainImageURL { get; set; }
        public int ManufacturerId { get; set; }
        public short Shipping { get; set; }
        public decimal Price { get; set; }
        public int Points { get; set; }
        public int TaxClassId { get; set; }
        public DateTime DateAvailable { get; set; }
        public decimal Weight { get; set; }
        public int WeightClassId { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int LengthClassId { get; set; }
        public short Subtract { get; set; }
        public int Minimum { get; set; }
        public int SortOrder { get; set; }
        public short Status { get; set; }
        public int Viewed { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
