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
        public StockStatus StockStatus { get; set; }
        public string MainImageURL { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public short Shipping { get; set; }
        public decimal Price { get; set; }
        public int Points { get; set; }
        public int TaxClassId { get; set; }
        public TaxClass TaxClass { get; set; }
        public DateTime DateAvailable { get; set; }
        public decimal Weight { get; set; }
        public int WeightClassId { get; set; }
        public WeightClass WeightClass { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int LengthClassId { get; set; }
        public LengthClass LengthClass { get; set; }
        public short Subtract { get; set; }
        public int Minimum { get; set; }
        public int SortOrder { get; set; }
        public short Status { get; set; }
        public int Viewed { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<ProductToCategory> ProductCategories { get; set; }
        public ICollection<ProductToDownload> ProductDownloads { get; set; }
        public ICollection<ProductDescription> ProductDescriptions { get; set; }
        public ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public ICollection<ProductFilter> ProductFilters { get; set; }
        public ICollection<ProductToLayout> Productlayouts { get; set; }
        public ICollection<ProductRecurring> ProductRecurrings { get; set; }
        public ICollection<ProductReward> ProductRewards { get; set; }
        public ICollection<ProductSpecial> ProductSpecials { get; set; }
        public ICollection<ProductToStore> ProductStores { get; set; }
        public ICollection<Return> Returns { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
