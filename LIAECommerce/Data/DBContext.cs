using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LIAECommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LIAECommerce.Data
{
    public class DBContext : IdentityDbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<ProductFilter> ProductFilters { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public DbSet<ProductRecurring> ProductRecurrings { get; set; }
        public DbSet<ProductRelated> ProductRelateds { get; set; }
        public DbSet<ProductSpecial> ProductSpecials { get; set; }
        public DbSet<ProductToCategory> ProductToCategories { get; set; }
        public DbSet<ProductToDownload> ProductToDownloads { get; set; }
        public DbSet<ProductToLayout> ProductToLayouts { get; set; }
        public DbSet<ProductToStore> ProductToStores { get; set; }
        public DbSet<Recurring> Recurrings { get; set; }
        public DbSet<RecurringDescription> RecurringDescriptions { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<ReturnAction> ReturnActions { get; set; }
        public DbSet<ReturnHistory> ReturnHistories { get; set; }
        public DbSet<ReturnReason> ReturnReasons { get; set; }
        public DbSet<ReturnStatus> ReturnStatus { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SeoUrl> SeoUrls { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<ShippingCourier> ShippingCouriers { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<StockStatus> StockStatus { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<TaxClass> TaxClasses { get; set; }
        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<TaxRateToCustomerGroup> TaxRateToCustomerGroups { get; set; }
        public DbSet<TaxRule> TaxRules { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Upload> Uploads { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherHistory> VoucherHistory { get; set; }
        public DbSet<VoucherTheme> VoucherThemes { get; set; }
        public DbSet<VoucherThemeDescription> VoucherThemeDescriptions { get; set; }
        public DbSet<WeightClass> WeightClasses { get; set; }
        public DbSet<WeightClassDescription> WeightClassDescriptions { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<ZoneToGeoZone> ZoneToGeoZones { get; set; }
    }
}
