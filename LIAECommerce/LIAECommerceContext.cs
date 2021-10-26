using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LIAECommerce
{
    public partial class LIAECommerceContext : DbContext
    {
        public LIAECommerceContext()
        {
        }

        public LIAECommerceContext(DbContextOptions<LIAECommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OcAddress> OcAddresses { get; set; }
        public virtual DbSet<OcApi> OcApis { get; set; }
        public virtual DbSet<OcApiIp> OcApiIps { get; set; }
        public virtual DbSet<OcApiSession> OcApiSessions { get; set; }
        public virtual DbSet<OcAttribute> OcAttributes { get; set; }
        public virtual DbSet<OcAttributeDescription> OcAttributeDescriptions { get; set; }
        public virtual DbSet<OcAttributeGroup> OcAttributeGroups { get; set; }
        public virtual DbSet<OcAttributeGroupDescription> OcAttributeGroupDescriptions { get; set; }
        public virtual DbSet<OcBanner> OcBanners { get; set; }
        public virtual DbSet<OcBannerImage> OcBannerImages { get; set; }
        public virtual DbSet<OcCart> OcCarts { get; set; }
        public virtual DbSet<OcCategory> OcCategories { get; set; }
        public virtual DbSet<OcCategoryDescription> OcCategoryDescriptions { get; set; }
        public virtual DbSet<OcCategoryFilter> OcCategoryFilters { get; set; }
        public virtual DbSet<OcCategoryPath> OcCategoryPaths { get; set; }
        public virtual DbSet<OcCategoryToLayout> OcCategoryToLayouts { get; set; }
        public virtual DbSet<OcCategoryToStore> OcCategoryToStores { get; set; }
        public virtual DbSet<OcCountry> OcCountries { get; set; }
        public virtual DbSet<OcCoupon> OcCoupons { get; set; }
        public virtual DbSet<OcCouponCategory> OcCouponCategories { get; set; }
        public virtual DbSet<OcCouponHistory> OcCouponHistories { get; set; }
        public virtual DbSet<OcCouponProduct> OcCouponProducts { get; set; }
        public virtual DbSet<OcCurrency> OcCurrencies { get; set; }
        public virtual DbSet<OcCustomField> OcCustomFields { get; set; }
        public virtual DbSet<OcCustomFieldCustomerGroup> OcCustomFieldCustomerGroups { get; set; }
        public virtual DbSet<OcCustomFieldDescription> OcCustomFieldDescriptions { get; set; }
        public virtual DbSet<OcCustomFieldValue> OcCustomFieldValues { get; set; }
        public virtual DbSet<OcCustomFieldValueDescription> OcCustomFieldValueDescriptions { get; set; }
        public virtual DbSet<OcCustomer> OcCustomers { get; set; }
        public virtual DbSet<OcCustomerActivity> OcCustomerActivities { get; set; }
        public virtual DbSet<OcCustomerAffiliate> OcCustomerAffiliates { get; set; }
        public virtual DbSet<OcCustomerApproval> OcCustomerApprovals { get; set; }
        public virtual DbSet<OcCustomerGroup> OcCustomerGroups { get; set; }
        public virtual DbSet<OcCustomerGroupDescription> OcCustomerGroupDescriptions { get; set; }
        public virtual DbSet<OcCustomerHistory> OcCustomerHistories { get; set; }
        public virtual DbSet<OcCustomerIp> OcCustomerIps { get; set; }
        public virtual DbSet<OcCustomerLogin> OcCustomerLogins { get; set; }
        public virtual DbSet<OcCustomerOnline> OcCustomerOnlines { get; set; }
        public virtual DbSet<OcCustomerReward> OcCustomerRewards { get; set; }
        public virtual DbSet<OcCustomerSearch> OcCustomerSearches { get; set; }
        public virtual DbSet<OcCustomerTransaction> OcCustomerTransactions { get; set; }
        public virtual DbSet<OcCustomerWishlist> OcCustomerWishlists { get; set; }
        public virtual DbSet<OcDownload> OcDownloads { get; set; }
        public virtual DbSet<OcDownloadDescription> OcDownloadDescriptions { get; set; }
        public virtual DbSet<OcEvent> OcEvents { get; set; }
        public virtual DbSet<OcExtension> OcExtensions { get; set; }
        public virtual DbSet<OcExtensionInstall> OcExtensionInstalls { get; set; }
        public virtual DbSet<OcExtensionPath> OcExtensionPaths { get; set; }
        public virtual DbSet<OcFilter> OcFilters { get; set; }
        public virtual DbSet<OcFilterDescription> OcFilterDescriptions { get; set; }
        public virtual DbSet<OcFilterGroup> OcFilterGroups { get; set; }
        public virtual DbSet<OcFilterGroupDescription> OcFilterGroupDescriptions { get; set; }
        public virtual DbSet<OcGeoZone> OcGeoZones { get; set; }
        public virtual DbSet<OcGoogleshoppingCategory> OcGoogleshoppingCategories { get; set; }
        public virtual DbSet<OcGoogleshoppingProduct> OcGoogleshoppingProducts { get; set; }
        public virtual DbSet<OcGoogleshoppingProductStatus> OcGoogleshoppingProductStatuses { get; set; }
        public virtual DbSet<OcGoogleshoppingProductTarget> OcGoogleshoppingProductTargets { get; set; }
        public virtual DbSet<OcGoogleshoppingTarget> OcGoogleshoppingTargets { get; set; }
        public virtual DbSet<OcInformation> OcInformations { get; set; }
        public virtual DbSet<OcInformationDescription> OcInformationDescriptions { get; set; }
        public virtual DbSet<OcInformationToLayout> OcInformationToLayouts { get; set; }
        public virtual DbSet<OcInformationToStore> OcInformationToStores { get; set; }
        public virtual DbSet<OcLanguage> OcLanguages { get; set; }
        public virtual DbSet<OcLayout> OcLayouts { get; set; }
        public virtual DbSet<OcLayoutModule> OcLayoutModules { get; set; }
        public virtual DbSet<OcLayoutRoute> OcLayoutRoutes { get; set; }
        public virtual DbSet<OcLengthClass> OcLengthClasses { get; set; }
        public virtual DbSet<OcLengthClassDescription> OcLengthClassDescriptions { get; set; }
        public virtual DbSet<OcLocation> OcLocations { get; set; }
        public virtual DbSet<OcManufacturer> OcManufacturers { get; set; }
        public virtual DbSet<OcManufacturerToStore> OcManufacturerToStores { get; set; }
        public virtual DbSet<OcMarketing> OcMarketings { get; set; }
        public virtual DbSet<OcModification> OcModifications { get; set; }
        public virtual DbSet<OcModule> OcModules { get; set; }
        public virtual DbSet<OcOption> OcOptions { get; set; }
        public virtual DbSet<OcOptionDescription> OcOptionDescriptions { get; set; }
        public virtual DbSet<OcOptionValue> OcOptionValues { get; set; }
        public virtual DbSet<OcOptionValueDescription> OcOptionValueDescriptions { get; set; }
        public virtual DbSet<OcOrder> OcOrders { get; set; }
        public virtual DbSet<OcOrderHistory> OcOrderHistories { get; set; }
        public virtual DbSet<OcOrderOption> OcOrderOptions { get; set; }
        public virtual DbSet<OcOrderProduct> OcOrderProducts { get; set; }
        public virtual DbSet<OcOrderRecurring> OcOrderRecurrings { get; set; }
        public virtual DbSet<OcOrderRecurringTransaction> OcOrderRecurringTransactions { get; set; }
        public virtual DbSet<OcOrderShipment> OcOrderShipments { get; set; }
        public virtual DbSet<OcOrderStatus> OcOrderStatuses { get; set; }
        public virtual DbSet<OcOrderTotal> OcOrderTotals { get; set; }
        public virtual DbSet<OcOrderVoucher> OcOrderVouchers { get; set; }
        public virtual DbSet<OcProduct> OcProducts { get; set; }
        public virtual DbSet<OcProductAttribute> OcProductAttributes { get; set; }
        public virtual DbSet<OcProductDescription> OcProductDescriptions { get; set; }
        public virtual DbSet<OcProductDiscount> OcProductDiscounts { get; set; }
        public virtual DbSet<OcProductFilter> OcProductFilters { get; set; }
        public virtual DbSet<OcProductImage> OcProductImages { get; set; }
        public virtual DbSet<OcProductOption> OcProductOptions { get; set; }
        public virtual DbSet<OcProductOptionValue> OcProductOptionValues { get; set; }
        public virtual DbSet<OcProductRecurring> OcProductRecurrings { get; set; }
        public virtual DbSet<OcProductRelated> OcProductRelateds { get; set; }
        public virtual DbSet<OcProductReward> OcProductRewards { get; set; }
        public virtual DbSet<OcProductSpecial> OcProductSpecials { get; set; }
        public virtual DbSet<OcProductToCategory> OcProductToCategories { get; set; }
        public virtual DbSet<OcProductToDownload> OcProductToDownloads { get; set; }
        public virtual DbSet<OcProductToLayout> OcProductToLayouts { get; set; }
        public virtual DbSet<OcProductToStore> OcProductToStores { get; set; }
        public virtual DbSet<OcRecurring> OcRecurrings { get; set; }
        public virtual DbSet<OcRecurringDescription> OcRecurringDescriptions { get; set; }
        public virtual DbSet<OcReturn> OcReturns { get; set; }
        public virtual DbSet<OcReturnAction> OcReturnActions { get; set; }
        public virtual DbSet<OcReturnHistory> OcReturnHistories { get; set; }
        public virtual DbSet<OcReturnReason> OcReturnReasons { get; set; }
        public virtual DbSet<OcReturnStatus> OcReturnStatuses { get; set; }
        public virtual DbSet<OcReview> OcReviews { get; set; }
        public virtual DbSet<OcSeoUrl> OcSeoUrls { get; set; }
        public virtual DbSet<OcSession> OcSessions { get; set; }
        public virtual DbSet<OcSetting> OcSettings { get; set; }
        public virtual DbSet<OcShippingCourier> OcShippingCouriers { get; set; }
        public virtual DbSet<OcStatistic> OcStatistics { get; set; }
        public virtual DbSet<OcStockStatus> OcStockStatuses { get; set; }
        public virtual DbSet<OcStore> OcStores { get; set; }
        public virtual DbSet<OcTaxClass> OcTaxClasses { get; set; }
        public virtual DbSet<OcTaxRate> OcTaxRates { get; set; }
        public virtual DbSet<OcTaxRateToCustomerGroup> OcTaxRateToCustomerGroups { get; set; }
        public virtual DbSet<OcTaxRule> OcTaxRules { get; set; }
        public virtual DbSet<OcTheme> OcThemes { get; set; }
        public virtual DbSet<OcTranslation> OcTranslations { get; set; }
        public virtual DbSet<OcUpload> OcUploads { get; set; }
        public virtual DbSet<OcUser> OcUsers { get; set; }
        public virtual DbSet<OcUserGroup> OcUserGroups { get; set; }
        public virtual DbSet<OcVoucher> OcVouchers { get; set; }
        public virtual DbSet<OcVoucherHistory> OcVoucherHistories { get; set; }
        public virtual DbSet<OcVoucherTheme> OcVoucherThemes { get; set; }
        public virtual DbSet<OcVoucherThemeDescription> OcVoucherThemeDescriptions { get; set; }
        public virtual DbSet<OcWeightClass> OcWeightClasses { get; set; }
        public virtual DbSet<OcWeightClassDescription> OcWeightClassDescriptions { get; set; }
        public virtual DbSet<OcZone> OcZones { get; set; }
        public virtual DbSet<OcZoneToGeoZone> OcZoneToGeoZones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PH8D08N\\SQLEXPRESS;Initial Catalog=LIAECommerce;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<OcAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_oc_address_address_id");

                entity.ToTable("oc_address", "storedemo");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("address_1");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("address_2");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("company");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("postcode");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            });

            modelBuilder.Entity<OcApi>(entity =>
            {
                entity.HasKey(e => e.ApiId)
                    .HasName("PK_oc_api_api_id");

                entity.ToTable("oc_api", "storedemo");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<OcApiIp>(entity =>
            {
                entity.HasKey(e => e.ApiIpId)
                    .HasName("PK_oc_api_ip_api_ip_id");

                entity.ToTable("oc_api_ip", "storedemo");

                entity.Property(e => e.ApiIpId).HasColumnName("api_ip_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<OcApiSession>(entity =>
            {
                entity.HasKey(e => e.ApiSessionId)
                    .HasName("PK_oc_api_session_api_session_id");

                entity.ToTable("oc_api_session", "storedemo");

                entity.Property(e => e.ApiSessionId).HasColumnName("api_session_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("session_id");
            });

            modelBuilder.Entity<OcAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PK_oc_attribute_attribute_id");

                entity.ToTable("oc_attribute", "storedemo");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcAttributeDescription>(entity =>
            {
                entity.HasKey(e => new { e.AttributeId, e.LanguageId })
                    .HasName("PK_oc_attribute_description_attribute_id");

                entity.ToTable("oc_attribute_description", "storedemo");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcAttributeGroup>(entity =>
            {
                entity.HasKey(e => e.AttributeGroupId)
                    .HasName("PK_oc_attribute_group_attribute_group_id");

                entity.ToTable("oc_attribute_group", "storedemo");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcAttributeGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.AttributeGroupId, e.LanguageId })
                    .HasName("PK_oc_attribute_group_description_attribute_group_id");

                entity.ToTable("oc_attribute_group_description", "storedemo");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcBanner>(entity =>
            {
                entity.HasKey(e => e.BannerId)
                    .HasName("PK_oc_banner_banner_id");

                entity.ToTable("oc_banner", "storedemo");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OcBannerImage>(entity =>
            {
                entity.HasKey(e => e.BannerImageId)
                    .HasName("PK_oc_banner_image_banner_image_id");

                entity.ToTable("oc_banner_image", "storedemo");

                entity.Property(e => e.BannerImageId).HasColumnName("banner_image_id");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK_oc_cart_cart_id");

                entity.ToTable("oc_cart", "storedemo");

                entity.HasIndex(e => new { e.ApiId, e.CustomerId, e.SessionId, e.ProductId, e.RecurringId }, "cart_id");

                entity.Property(e => e.CartId).HasColumnName("cart_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Option)
                    .IsRequired()
                    .HasColumnName("option");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("session_id");
            });

            modelBuilder.Entity<OcCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_oc_category_category_id");

                entity.ToTable("oc_category", "storedemo");

                entity.HasIndex(e => e.ParentId, "parent_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Column).HasColumnName("column");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Top).HasColumnName("top");
            });

            modelBuilder.Entity<OcCategoryDescription>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.LanguageId })
                    .HasName("PK_oc_category_description_category_id");

                entity.ToTable("oc_category_description", "storedemo");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCategoryFilter>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.FilterId })
                    .HasName("PK_oc_category_filter_category_id");

                entity.ToTable("oc_category_filter", "storedemo");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");
            });

            modelBuilder.Entity<OcCategoryPath>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PathId })
                    .HasName("PK_oc_category_path_category_id");

                entity.ToTable("oc_category_path", "storedemo");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.PathId).HasColumnName("path_id");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<OcCategoryToLayout>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId })
                    .HasName("PK_oc_category_to_layout_category_id");

                entity.ToTable("oc_category_to_layout", "storedemo");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcCategoryToStore>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId })
                    .HasName("PK_oc_category_to_store_category_id");

                entity.ToTable("oc_category_to_store", "storedemo");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_oc_country_country_id");

                entity.ToTable("oc_country", "storedemo");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.AddressFormat)
                    .IsRequired()
                    .HasColumnName("address_format");

                entity.Property(e => e.IsoCode2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("iso_code_2");

                entity.Property(e => e.IsoCode3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("iso_code_3");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PostcodeRequired).HasColumnName("postcode_required");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OcCoupon>(entity =>
            {
                entity.HasKey(e => e.CouponId)
                    .HasName("PK_oc_coupon_coupon_id");

                entity.ToTable("oc_coupon", "storedemo");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("discount");

                entity.Property(e => e.Logged).HasColumnName("logged");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Shipping).HasColumnName("shipping");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);

                entity.Property(e => e.UsesCustomer)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("uses_customer");

                entity.Property(e => e.UsesTotal).HasColumnName("uses_total");
            });

            modelBuilder.Entity<OcCouponCategory>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.CategoryId })
                    .HasName("PK_oc_coupon_category_coupon_id");

                entity.ToTable("oc_coupon_category", "storedemo");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OcCouponHistory>(entity =>
            {
                entity.HasKey(e => e.CouponHistoryId)
                    .HasName("PK_oc_coupon_history_coupon_history_id");

                entity.ToTable("oc_coupon_history", "storedemo");

                entity.Property(e => e.CouponHistoryId).HasColumnName("coupon_history_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");
            });

            modelBuilder.Entity<OcCouponProduct>(entity =>
            {
                entity.HasKey(e => e.CouponProductId)
                    .HasName("PK_oc_coupon_product_coupon_product_id");

                entity.ToTable("oc_coupon_product", "storedemo");

                entity.Property(e => e.CouponProductId).HasColumnName("coupon_product_id");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PK_oc_currency_currency_id");

                entity.ToTable("oc_currency", "storedemo");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("code");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.DecimalPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("decimal_place")
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SymbolLeft)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("symbol_left");

                entity.Property(e => e.SymbolRight)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("symbol_right");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");

                entity.Property(e => e.Value)
                    .HasColumnType("numeric(15, 8)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcCustomField>(entity =>
            {
                entity.HasKey(e => e.CustomFieldId)
                    .HasName("PK_oc_custom_field_custom_field_id");

                entity.ToTable("oc_custom_field", "storedemo");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("location");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.Validation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("validation");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcCustomFieldCustomerGroup>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldId, e.CustomerGroupId })
                    .HasName("PK_oc_custom_field_customer_group_custom_field_id");

                entity.ToTable("oc_custom_field_customer_group", "storedemo");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Required).HasColumnName("required");
            });

            modelBuilder.Entity<OcCustomFieldDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldId, e.LanguageId })
                    .HasName("PK_oc_custom_field_description_custom_field_id");

                entity.ToTable("oc_custom_field_description", "storedemo");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCustomFieldValue>(entity =>
            {
                entity.HasKey(e => e.CustomFieldValueId)
                    .HasName("PK_oc_custom_field_value_custom_field_value_id");

                entity.ToTable("oc_custom_field_value", "storedemo");

                entity.Property(e => e.CustomFieldValueId).HasColumnName("custom_field_value_id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcCustomFieldValueDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldValueId, e.LanguageId })
                    .HasName("PK_oc_custom_field_value_description_custom_field_value_id");

                entity.ToTable("oc_custom_field_value_description", "storedemo");

                entity.Property(e => e.CustomFieldValueId).HasColumnName("custom_field_value_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_oc_customer_customer_id");

                entity.ToTable("oc_customer", "storedemo");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Cart).HasColumnName("cart");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("code");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Newsletter).HasColumnName("newsletter");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("password");

                entity.Property(e => e.Safe).HasColumnName("safe");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("salt");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token");

                entity.Property(e => e.Wishlist).HasColumnName("wishlist");
            });

            modelBuilder.Entity<OcCustomerActivity>(entity =>
            {
                entity.HasKey(e => e.CustomerActivityId)
                    .HasName("PK_oc_customer_activity_customer_activity_id");

                entity.ToTable("oc_customer_activity", "storedemo");

                entity.Property(e => e.CustomerActivityId).HasColumnName("customer_activity_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("key");
            });

            modelBuilder.Entity<OcCustomerAffiliate>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_oc_customer_affiliate_customer_id");

                entity.ToTable("oc_customer_affiliate", "storedemo");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("customer_id");

                entity.Property(e => e.BankAccountName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_account_name");

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_account_number");

                entity.Property(e => e.BankBranchNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_branch_number");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BankSwiftCode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_swift_code");

                entity.Property(e => e.Cheque)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cheque");

                entity.Property(e => e.Commission)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("commission")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("company");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("payment");

                entity.Property(e => e.Paypal)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("paypal");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tax)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tax");

                entity.Property(e => e.Tracking)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tracking");

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("website");
            });

            modelBuilder.Entity<OcCustomerApproval>(entity =>
            {
                entity.HasKey(e => e.CustomerApprovalId)
                    .HasName("PK_oc_customer_approval_customer_approval_id");

                entity.ToTable("oc_customer_approval", "storedemo");

                entity.Property(e => e.CustomerApprovalId).HasColumnName("customer_approval_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcCustomerGroup>(entity =>
            {
                entity.HasKey(e => e.CustomerGroupId)
                    .HasName("PK_oc_customer_group_customer_group_id");

                entity.ToTable("oc_customer_group", "storedemo");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Approval).HasColumnName("approval");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcCustomerGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGroupId, e.LanguageId })
                    .HasName("PK_oc_customer_group_description_customer_group_id");

                entity.ToTable("oc_customer_group_description", "storedemo");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCustomerHistory>(entity =>
            {
                entity.HasKey(e => e.CustomerHistoryId)
                    .HasName("PK_oc_customer_history_customer_history_id");

                entity.ToTable("oc_customer_history", "storedemo");

                entity.Property(e => e.CustomerHistoryId).HasColumnName("customer_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");
            });

            modelBuilder.Entity<OcCustomerIp>(entity =>
            {
                entity.HasKey(e => e.CustomerIpId)
                    .HasName("PK_oc_customer_ip_customer_ip_id");

                entity.ToTable("oc_customer_ip", "storedemo");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.CustomerIpId).HasColumnName("customer_ip_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<OcCustomerLogin>(entity =>
            {
                entity.HasKey(e => e.CustomerLoginId)
                    .HasName("PK_oc_customer_login_customer_login_id");

                entity.ToTable("oc_customer_login", "storedemo");

                entity.HasIndex(e => e.Email, "email");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.CustomerLoginId).HasColumnName("customer_login_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<OcCustomerOnline>(entity =>
            {
                entity.HasKey(e => e.Ip)
                    .HasName("PK_oc_customer_online_ip");

                entity.ToTable("oc_customer_online", "storedemo");

                entity.Property(e => e.Ip)
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnName("referer");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");
            });

            modelBuilder.Entity<OcCustomerReward>(entity =>
            {
                entity.HasKey(e => e.CustomerRewardId)
                    .HasName("PK_oc_customer_reward_customer_reward_id");

                entity.ToTable("oc_customer_reward", "storedemo");

                entity.Property(e => e.CustomerRewardId).HasColumnName("customer_reward_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Points).HasColumnName("points");
            });

            modelBuilder.Entity<OcCustomerSearch>(entity =>
            {
                entity.HasKey(e => e.CustomerSearchId)
                    .HasName("PK_oc_customer_search_customer_search_id");

                entity.ToTable("oc_customer_search", "storedemo");

                entity.Property(e => e.CustomerSearchId).HasColumnName("customer_search_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Products).HasColumnName("products");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.SubCategory).HasColumnName("sub_category");
            });

            modelBuilder.Entity<OcCustomerTransaction>(entity =>
            {
                entity.HasKey(e => e.CustomerTransactionId)
                    .HasName("PK_oc_customer_transaction_customer_transaction_id");

                entity.ToTable("oc_customer_transaction", "storedemo");

                entity.Property(e => e.CustomerTransactionId).HasColumnName("customer_transaction_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");
            });

            modelBuilder.Entity<OcCustomerWishlist>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductId })
                    .HasName("PK_oc_customer_wishlist_customer_id");

                entity.ToTable("oc_customer_wishlist", "storedemo");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");
            });

            modelBuilder.Entity<OcDownload>(entity =>
            {
                entity.HasKey(e => e.DownloadId)
                    .HasName("PK_oc_download_download_id");

                entity.ToTable("oc_download", "storedemo");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(160)
                    .HasColumnName("filename");

                entity.Property(e => e.Mask)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("mask");
            });

            modelBuilder.Entity<OcDownloadDescription>(entity =>
            {
                entity.HasKey(e => new { e.DownloadId, e.LanguageId })
                    .HasName("PK_oc_download_description_download_id");

                entity.ToTable("oc_download_description", "storedemo");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_oc_event_event_id");

                entity.ToTable("oc_event", "storedemo");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Trigger)
                    .IsRequired()
                    .HasColumnName("trigger");
            });

            modelBuilder.Entity<OcExtension>(entity =>
            {
                entity.HasKey(e => e.ExtensionId)
                    .HasName("PK_oc_extension_extension_id");

                entity.ToTable("oc_extension", "storedemo");

                entity.Property(e => e.ExtensionId).HasColumnName("extension_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcExtensionInstall>(entity =>
            {
                entity.HasKey(e => e.ExtensionInstallId)
                    .HasName("PK_oc_extension_install_extension_install_id");

                entity.ToTable("oc_extension_install", "storedemo");

                entity.Property(e => e.ExtensionInstallId).HasColumnName("extension_install_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.ExtensionDownloadId).HasColumnName("extension_download_id");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("filename");
            });

            modelBuilder.Entity<OcExtensionPath>(entity =>
            {
                entity.HasKey(e => e.ExtensionPathId)
                    .HasName("PK_oc_extension_path_extension_path_id");

                entity.ToTable("oc_extension_path", "storedemo");

                entity.Property(e => e.ExtensionPathId).HasColumnName("extension_path_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.ExtensionInstallId).HasColumnName("extension_install_id");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<OcFilter>(entity =>
            {
                entity.HasKey(e => e.FilterId)
                    .HasName("PK_oc_filter_filter_id");

                entity.ToTable("oc_filter", "storedemo");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcFilterDescription>(entity =>
            {
                entity.HasKey(e => new { e.FilterId, e.LanguageId })
                    .HasName("PK_oc_filter_description_filter_id");

                entity.ToTable("oc_filter_description", "storedemo");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcFilterGroup>(entity =>
            {
                entity.HasKey(e => e.FilterGroupId)
                    .HasName("PK_oc_filter_group_filter_group_id");

                entity.ToTable("oc_filter_group", "storedemo");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcFilterGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.FilterGroupId, e.LanguageId })
                    .HasName("PK_oc_filter_group_description_filter_group_id");

                entity.ToTable("oc_filter_group_description", "storedemo");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcGeoZone>(entity =>
            {
                entity.HasKey(e => e.GeoZoneId)
                    .HasName("PK_oc_geo_zone_geo_zone_id");

                entity.ToTable("oc_geo_zone", "storedemo");

                entity.Property(e => e.GeoZoneId).HasColumnName("geo_zone_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcGoogleshoppingCategory>(entity =>
            {
                entity.HasKey(e => new { e.GoogleProductCategory, e.StoreId })
                    .HasName("PK_oc_googleshopping_category_google_product_category");

                entity.ToTable("oc_googleshopping_category", "storedemo");

                entity.HasIndex(e => new { e.CategoryId, e.StoreId }, "category_id_store_id");

                entity.Property(e => e.GoogleProductCategory)
                    .HasMaxLength(10)
                    .HasColumnName("google_product_category");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OcGoogleshoppingProduct>(entity =>
            {
                entity.HasKey(e => e.ProductAdvertiseGoogleId)
                    .HasName("PK_oc_googleshopping_product_product_advertise_google_id");

                entity.ToTable("oc_googleshopping_product", "storedemo");

                entity.HasIndex(e => new { e.ProductId, e.StoreId }, "oc_googleshopping_product$product_id_store_id")
                    .IsUnique();

                entity.Property(e => e.ProductAdvertiseGoogleId).HasColumnName("product_advertise_google_id");

                entity.Property(e => e.Adult).HasColumnName("adult");

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(7)
                    .HasColumnName("age_group");

                entity.Property(e => e.Clicks).HasColumnName("clicks");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.Condition)
                    .HasMaxLength(11)
                    .HasColumnName("condition");

                entity.Property(e => e.ConversionValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("conversion_value")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.Conversions).HasColumnName("conversions");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("cost")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.DestinationStatus)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("destination_status")
                    .HasDefaultValueSql("(N'pending')");

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .HasColumnName("gender");

                entity.Property(e => e.GoogleProductCategory)
                    .HasMaxLength(10)
                    .HasColumnName("google_product_category");

                entity.Property(e => e.HasIssues).HasColumnName("has_issues");

                entity.Property(e => e.Impressions).HasColumnName("impressions");

                entity.Property(e => e.IsBundle).HasColumnName("is_bundle");

                entity.Property(e => e.IsModified).HasColumnName("is_modified");

                entity.Property(e => e.Multipack).HasColumnName("multipack");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.SizeSystem)
                    .HasMaxLength(3)
                    .HasColumnName("size_system");

                entity.Property(e => e.SizeType)
                    .HasMaxLength(12)
                    .HasColumnName("size_type");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcGoogleshoppingProductStatus>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId, e.ProductVariationId })
                    .HasName("PK_oc_googleshopping_product_status_product_id");

                entity.ToTable("oc_googleshopping_product_status", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.ProductVariationId)
                    .HasMaxLength(64)
                    .HasColumnName("product_variation_id")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DataQualityIssues)
                    .IsRequired()
                    .HasColumnName("data_quality_issues");

                entity.Property(e => e.DestinationStatuses)
                    .IsRequired()
                    .HasColumnName("destination_statuses");

                entity.Property(e => e.GoogleExpirationDate).HasColumnName("google_expiration_date");

                entity.Property(e => e.ItemLevelIssues)
                    .IsRequired()
                    .HasColumnName("item_level_issues");
            });

            modelBuilder.Entity<OcGoogleshoppingProductTarget>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.AdvertiseGoogleTargetId })
                    .HasName("PK_oc_googleshopping_product_target_product_id");

                entity.ToTable("oc_googleshopping_product_target", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.AdvertiseGoogleTargetId).HasColumnName("advertise_google_target_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcGoogleshoppingTarget>(entity =>
            {
                entity.HasKey(e => e.AdvertiseGoogleTargetId)
                    .HasName("PK_oc_googleshopping_target_advertise_google_target_id");

                entity.ToTable("oc_googleshopping_target", "storedemo");

                entity.HasIndex(e => e.StoreId, "store_id");

                entity.Property(e => e.AdvertiseGoogleTargetId)
                    .ValueGeneratedNever()
                    .HasColumnName("advertise_google_target_id");

                entity.Property(e => e.Budget)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("budget")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("campaign_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("country")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added");

                entity.Property(e => e.Feeds)
                    .IsRequired()
                    .HasColumnName("feeds");

                entity.Property(e => e.Roas).HasColumnName("roas");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(N'paused')");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcInformation>(entity =>
            {
                entity.HasKey(e => e.InformationId)
                    .HasName("PK_oc_information_information_id");

                entity.ToTable("oc_information", "storedemo");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.Bottom).HasColumnName("bottom");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OcInformationDescription>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.LanguageId })
                    .HasName("PK_oc_information_description_information_id");

                entity.ToTable("oc_information_description", "storedemo");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcInformationToLayout>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.StoreId })
                    .HasName("PK_oc_information_to_layout_information_id");

                entity.ToTable("oc_information_to_layout", "storedemo");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcInformationToStore>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.StoreId })
                    .HasName("PK_oc_information_to_store_information_id");

                entity.ToTable("oc_information_to_store", "storedemo");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK_oc_language_language_id");

                entity.ToTable("oc_language", "storedemo");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("code");

                entity.Property(e => e.Directory)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("directory");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("image");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("locale");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OcLayout>(entity =>
            {
                entity.HasKey(e => e.LayoutId)
                    .HasName("PK_oc_layout_layout_id");

                entity.ToTable("oc_layout", "storedemo");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcLayoutModule>(entity =>
            {
                entity.HasKey(e => e.LayoutModuleId)
                    .HasName("PK_oc_layout_module_layout_module_id");

                entity.ToTable("oc_layout_module", "storedemo");

                entity.Property(e => e.LayoutModuleId).HasColumnName("layout_module_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("position");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcLayoutRoute>(entity =>
            {
                entity.HasKey(e => e.LayoutRouteId)
                    .HasName("PK_oc_layout_route_layout_route_id");

                entity.ToTable("oc_layout_route", "storedemo");

                entity.Property(e => e.LayoutRouteId).HasColumnName("layout_route_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcLengthClass>(entity =>
            {
                entity.HasKey(e => e.LengthClassId)
                    .HasName("PK_oc_length_class_length_class_id");

                entity.ToTable("oc_length_class", "storedemo");

                entity.Property(e => e.LengthClassId).HasColumnName("length_class_id");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcLengthClassDescription>(entity =>
            {
                entity.HasKey(e => new { e.LengthClassId, e.LanguageId })
                    .HasName("PK_oc_length_class_description_length_class_id");

                entity.ToTable("oc_length_class_description", "storedemo");

                entity.Property(e => e.LengthClassId).HasColumnName("length_class_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<OcLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK_oc_location_location_id");

                entity.ToTable("oc_location", "storedemo");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Geocode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("geocode");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.Open)
                    .IsRequired()
                    .HasColumnName("open");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<OcManufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId)
                    .HasName("PK_oc_manufacturer_manufacturer_id");

                entity.ToTable("oc_manufacturer", "storedemo");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcManufacturerToStore>(entity =>
            {
                entity.HasKey(e => new { e.ManufacturerId, e.StoreId })
                    .HasName("PK_oc_manufacturer_to_store_manufacturer_id");

                entity.ToTable("oc_manufacturer_to_store", "storedemo");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcMarketing>(entity =>
            {
                entity.HasKey(e => e.MarketingId)
                    .HasName("PK_oc_marketing_marketing_id");

                entity.ToTable("oc_marketing", "storedemo");

                entity.Property(e => e.MarketingId).HasColumnName("marketing_id");

                entity.Property(e => e.Clicks).HasColumnName("clicks");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcModification>(entity =>
            {
                entity.HasKey(e => e.ModificationId)
                    .HasName("PK_oc_modification_modification_id");

                entity.ToTable("oc_modification", "storedemo");

                entity.Property(e => e.ModificationId).HasColumnName("modification_id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("author");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.ExtensionInstallId).HasColumnName("extension_install_id");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("version");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml");
            });

            modelBuilder.Entity<OcModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_oc_module_module_id");

                entity.ToTable("oc_module", "storedemo");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasColumnName("setting");
            });

            modelBuilder.Entity<OcOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PK_oc_option_option_id");

                entity.ToTable("oc_option", "storedemo");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcOptionDescription>(entity =>
            {
                entity.HasKey(e => new { e.OptionId, e.LanguageId })
                    .HasName("PK_oc_option_description_option_id");

                entity.ToTable("oc_option_description", "storedemo");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcOptionValue>(entity =>
            {
                entity.HasKey(e => e.OptionValueId)
                    .HasName("PK_oc_option_value_option_value_id");

                entity.ToTable("oc_option_value", "storedemo");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcOptionValueDescription>(entity =>
            {
                entity.HasKey(e => new { e.OptionValueId, e.LanguageId })
                    .HasName("PK_oc_option_value_description_option_value_id");

                entity.ToTable("oc_option_value_description", "storedemo");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.OptionId).HasColumnName("option_id");
            });

            modelBuilder.Entity<OcOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_oc_order_order_id");

                entity.ToTable("oc_order", "storedemo");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.AcceptLanguage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("accept_language");

                entity.Property(e => e.AffiliateId).HasColumnName("affiliate_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Commission)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("commission");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("currency_code");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CurrencyValue)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("currency_value")
                    .HasDefaultValueSql("((1.00000000))");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.ForwardedIp)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("forwarded_ip");

                entity.Property(e => e.InvoiceNo).HasColumnName("invoice_no");

                entity.Property(e => e.InvoicePrefix)
                    .IsRequired()
                    .HasMaxLength(26)
                    .HasColumnName("invoice_prefix");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.MarketingId).HasColumnName("marketing_id");

                entity.Property(e => e.OrderStatusId).HasColumnName("order_status_id");

                entity.Property(e => e.PaymentAddress1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_address_1");

                entity.Property(e => e.PaymentAddress2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_address_2");

                entity.Property(e => e.PaymentAddressFormat)
                    .IsRequired()
                    .HasColumnName("payment_address_format");

                entity.Property(e => e.PaymentCity)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_city");

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_code");

                entity.Property(e => e.PaymentCompany)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("payment_company");

                entity.Property(e => e.PaymentCountry)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_country");

                entity.Property(e => e.PaymentCountryId).HasColumnName("payment_country_id");

                entity.Property(e => e.PaymentCustomField)
                    .IsRequired()
                    .HasColumnName("payment_custom_field");

                entity.Property(e => e.PaymentFirstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("payment_firstname");

                entity.Property(e => e.PaymentLastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("payment_lastname");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_method");

                entity.Property(e => e.PaymentPostcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("payment_postcode");

                entity.Property(e => e.PaymentZone)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_zone");

                entity.Property(e => e.PaymentZoneId).HasColumnName("payment_zone_id");

                entity.Property(e => e.ShippingAddress1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_address_1");

                entity.Property(e => e.ShippingAddress2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_address_2");

                entity.Property(e => e.ShippingAddressFormat)
                    .IsRequired()
                    .HasColumnName("shipping_address_format");

                entity.Property(e => e.ShippingCity)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_city");

                entity.Property(e => e.ShippingCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_code");

                entity.Property(e => e.ShippingCompany)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("shipping_company");

                entity.Property(e => e.ShippingCountry)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_country");

                entity.Property(e => e.ShippingCountryId).HasColumnName("shipping_country_id");

                entity.Property(e => e.ShippingCustomField)
                    .IsRequired()
                    .HasColumnName("shipping_custom_field");

                entity.Property(e => e.ShippingFirstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("shipping_firstname");

                entity.Property(e => e.ShippingLastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("shipping_lastname");

                entity.Property(e => e.ShippingMethod)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_method");

                entity.Property(e => e.ShippingPostcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("shipping_postcode");

                entity.Property(e => e.ShippingZone)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_zone");

                entity.Property(e => e.ShippingZoneId).HasColumnName("shipping_zone_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("store_url");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.Tracking)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tracking");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");
            });

            modelBuilder.Entity<OcOrderHistory>(entity =>
            {
                entity.HasKey(e => e.OrderHistoryId)
                    .HasName("PK_oc_order_history_order_history_id");

                entity.ToTable("oc_order_history", "storedemo");

                entity.Property(e => e.OrderHistoryId).HasColumnName("order_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Notify).HasColumnName("notify");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderStatusId).HasColumnName("order_status_id");
            });

            modelBuilder.Entity<OcOrderOption>(entity =>
            {
                entity.HasKey(e => e.OrderOptionId)
                    .HasName("PK_oc_order_option_order_option_id");

                entity.ToTable("oc_order_option", "storedemo");

                entity.Property(e => e.OrderOptionId).HasColumnName("order_option_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderProductId).HasColumnName("order_product_id");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.ProductOptionValueId).HasColumnName("product_option_value_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcOrderProduct>(entity =>
            {
                entity.HasKey(e => e.OrderProductId)
                    .HasName("PK_oc_order_product_order_product_id");

                entity.ToTable("oc_order_product", "storedemo");

                entity.HasIndex(e => e.OrderId, "order_id");

                entity.Property(e => e.OrderProductId).HasColumnName("order_product_id");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("price")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Reward).HasColumnName("reward");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("tax")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total")
                    .HasDefaultValueSql("((0.0000))");
            });

            modelBuilder.Entity<OcOrderRecurring>(entity =>
            {
                entity.HasKey(e => e.OrderRecurringId)
                    .HasName("PK_oc_order_recurring_order_recurring_id");

                entity.ToTable("oc_order_recurring", "storedemo");

                entity.Property(e => e.OrderRecurringId).HasColumnName("order_recurring_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.RecurringCycle).HasColumnName("recurring_cycle");

                entity.Property(e => e.RecurringDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("recurring_description");

                entity.Property(e => e.RecurringDuration).HasColumnName("recurring_duration");

                entity.Property(e => e.RecurringFrequency)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("recurring_frequency");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.RecurringName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("recurring_name");

                entity.Property(e => e.RecurringPrice)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("recurring_price");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Trial).HasColumnName("trial");

                entity.Property(e => e.TrialCycle).HasColumnName("trial_cycle");

                entity.Property(e => e.TrialDuration).HasColumnName("trial_duration");

                entity.Property(e => e.TrialFrequency)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("trial_frequency");

                entity.Property(e => e.TrialPrice)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("trial_price");
            });

            modelBuilder.Entity<OcOrderRecurringTransaction>(entity =>
            {
                entity.HasKey(e => e.OrderRecurringTransactionId)
                    .HasName("PK_oc_order_recurring_transaction_order_recurring_transaction_id");

                entity.ToTable("oc_order_recurring_transaction", "storedemo");

                entity.Property(e => e.OrderRecurringTransactionId).HasColumnName("order_recurring_transaction_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.OrderRecurringId).HasColumnName("order_recurring_id");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcOrderShipment>(entity =>
            {
                entity.HasKey(e => e.OrderShipmentId)
                    .HasName("PK_oc_order_shipment_order_shipment_id");

                entity.ToTable("oc_order_shipment", "storedemo");

                entity.Property(e => e.OrderShipmentId).HasColumnName("order_shipment_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ShippingCourierId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shipping_courier_id")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tracking_number")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OcOrderStatus>(entity =>
            {
                entity.HasKey(e => new { e.OrderStatusId, e.LanguageId })
                    .HasName("PK_oc_order_status_order_status_id");

                entity.ToTable("oc_order_status", "storedemo");

                entity.Property(e => e.OrderStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("order_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcOrderTotal>(entity =>
            {
                entity.HasKey(e => e.OrderTotalId)
                    .HasName("PK_oc_order_total_order_total_id");

                entity.ToTable("oc_order_total", "storedemo");

                entity.HasIndex(e => e.OrderId, "order_id");

                entity.Property(e => e.OrderTotalId).HasColumnName("order_total_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("value")
                    .HasDefaultValueSql("((0.0000))");
            });

            modelBuilder.Entity<OcOrderVoucher>(entity =>
            {
                entity.HasKey(e => e.OrderVoucherId)
                    .HasName("PK_oc_order_voucher_order_voucher_id");

                entity.ToTable("oc_order_voucher", "storedemo");

                entity.Property(e => e.OrderVoucherId).HasColumnName("order_voucher_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.FromEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("from_email");

                entity.Property(e => e.FromName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("from_name");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ToEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("to_email");

                entity.Property(e => e.ToName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("to_name");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");
            });

            modelBuilder.Entity<OcProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_oc_product_product_id");

                entity.ToTable("oc_product", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateAvailable)
                    .HasColumnType("date")
                    .HasColumnName("date_available")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("ean");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("height")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("isbn");

                entity.Property(e => e.Jan)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("jan");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("length")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.LengthClassId).HasColumnName("length_class_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("location");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.Minimum)
                    .HasColumnName("minimum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Mpn)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("mpn");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("price")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shipping)
                    .HasColumnName("shipping")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("sku");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockStatusId).HasColumnName("stock_status_id");

                entity.Property(e => e.Subtract)
                    .HasColumnName("subtract")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxClassId).HasColumnName("tax_class_id");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("upc");

                entity.Property(e => e.Viewed).HasColumnName("viewed");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("weight")
                    .HasDefaultValueSql("((0.00000000))");

                entity.Property(e => e.WeightClassId).HasColumnName("weight_class_id");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("width")
                    .HasDefaultValueSql("((0.00000000))");
            });

            modelBuilder.Entity<OcProductAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.AttributeId, e.LanguageId })
                    .HasName("PK_oc_product_attribute_product_id");

                entity.ToTable("oc_product_attribute", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OcProductDescription>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LanguageId })
                    .HasName("PK_oc_product_description_product_id");

                entity.ToTable("oc_product_description", "storedemo");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<OcProductDiscount>(entity =>
            {
                entity.HasKey(e => e.ProductDiscountId)
                    .HasName("PK_oc_product_discount_product_discount_id");

                entity.ToTable("oc_product_discount", "storedemo");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductDiscountId).HasColumnName("product_discount_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("price")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<OcProductFilter>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.FilterId })
                    .HasName("PK_oc_product_filter_product_id");

                entity.ToTable("oc_product_filter", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");
            });

            modelBuilder.Entity<OcProductImage>(entity =>
            {
                entity.HasKey(e => e.ProductImageId)
                    .HasName("PK_oc_product_image_product_image_id");

                entity.ToTable("oc_product_image", "storedemo");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductImageId).HasColumnName("product_image_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcProductOption>(entity =>
            {
                entity.HasKey(e => e.ProductOptionId)
                    .HasName("PK_oc_product_option_product_option_id");

                entity.ToTable("oc_product_option", "storedemo");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcProductOptionValue>(entity =>
            {
                entity.HasKey(e => e.ProductOptionValueId)
                    .HasName("PK_oc_product_option_value_product_option_value_id");

                entity.ToTable("oc_product_option_value", "storedemo");

                entity.Property(e => e.ProductOptionValueId).HasColumnName("product_option_value_id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.PointsPrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("points_prefix");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("price");

                entity.Property(e => e.PricePrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("price_prefix");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Subtract).HasColumnName("subtract");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("weight");

                entity.Property(e => e.WeightPrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("weight_prefix");
            });

            modelBuilder.Entity<OcProductRecurring>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RecurringId, e.CustomerGroupId })
                    .HasName("PK_oc_product_recurring_product_id");

                entity.ToTable("oc_product_recurring", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");
            });

            modelBuilder.Entity<OcProductRelated>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RelatedId })
                    .HasName("PK_oc_product_related_product_id");

                entity.ToTable("oc_product_related", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.RelatedId).HasColumnName("related_id");
            });

            modelBuilder.Entity<OcProductReward>(entity =>
            {
                entity.HasKey(e => e.ProductRewardId)
                    .HasName("PK_oc_product_reward_product_reward_id");

                entity.ToTable("oc_product_reward", "storedemo");

                entity.Property(e => e.ProductRewardId).HasColumnName("product_reward_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcProductSpecial>(entity =>
            {
                entity.HasKey(e => e.ProductSpecialId)
                    .HasName("PK_oc_product_special_product_special_id");

                entity.ToTable("oc_product_special", "storedemo");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductSpecialId).HasColumnName("product_special_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("price")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcProductToCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryId })
                    .HasName("PK_oc_product_to_category_product_id");

                entity.ToTable("oc_product_to_category", "storedemo");

                entity.HasIndex(e => e.CategoryId, "category_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OcProductToDownload>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.DownloadId })
                    .HasName("PK_oc_product_to_download_product_id");

                entity.ToTable("oc_product_to_download", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");
            });

            modelBuilder.Entity<OcProductToLayout>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId })
                    .HasName("PK_oc_product_to_layout_product_id");

                entity.ToTable("oc_product_to_layout", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcProductToStore>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId })
                    .HasName("PK_oc_product_to_store_product_id");

                entity.ToTable("oc_product_to_store", "storedemo");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcRecurring>(entity =>
            {
                entity.HasKey(e => e.RecurringId)
                    .HasName("PK_oc_recurring_recurring_id");

                entity.ToTable("oc_recurring", "storedemo");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.Cycle).HasColumnName("cycle");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("frequency");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("price");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TrialCycle).HasColumnName("trial_cycle");

                entity.Property(e => e.TrialDuration).HasColumnName("trial_duration");

                entity.Property(e => e.TrialFrequency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("trial_frequency");

                entity.Property(e => e.TrialPrice)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("trial_price");

                entity.Property(e => e.TrialStatus).HasColumnName("trial_status");
            });

            modelBuilder.Entity<OcRecurringDescription>(entity =>
            {
                entity.HasKey(e => new { e.RecurringId, e.LanguageId })
                    .HasName("PK_oc_recurring_description_recurring_id");

                entity.ToTable("oc_recurring_description", "storedemo");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK_oc_return_return_id");

                entity.ToTable("oc_return", "storedemo");

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.DateOrdered)
                    .HasColumnType("date")
                    .HasColumnName("date_ordered")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Opened).HasColumnName("opened");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReturnActionId).HasColumnName("return_action_id");

                entity.Property(e => e.ReturnReasonId).HasColumnName("return_reason_id");

                entity.Property(e => e.ReturnStatusId).HasColumnName("return_status_id");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<OcReturnAction>(entity =>
            {
                entity.HasKey(e => new { e.ReturnActionId, e.LanguageId })
                    .HasName("PK_oc_return_action_return_action_id");

                entity.ToTable("oc_return_action", "storedemo");

                entity.Property(e => e.ReturnActionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("return_action_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReturnHistory>(entity =>
            {
                entity.HasKey(e => e.ReturnHistoryId)
                    .HasName("PK_oc_return_history_return_history_id");

                entity.ToTable("oc_return_history", "storedemo");

                entity.Property(e => e.ReturnHistoryId).HasColumnName("return_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Notify).HasColumnName("notify");

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.ReturnStatusId).HasColumnName("return_status_id");
            });

            modelBuilder.Entity<OcReturnReason>(entity =>
            {
                entity.HasKey(e => new { e.ReturnReasonId, e.LanguageId })
                    .HasName("PK_oc_return_reason_return_reason_id");

                entity.ToTable("oc_return_reason", "storedemo");

                entity.Property(e => e.ReturnReasonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("return_reason_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReturnStatus>(entity =>
            {
                entity.HasKey(e => new { e.ReturnStatusId, e.LanguageId })
                    .HasName("PK_oc_return_status_return_status_id");

                entity.ToTable("oc_return_status", "storedemo");

                entity.Property(e => e.ReturnStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("return_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PK_oc_review_review_id");

                entity.ToTable("oc_review", "storedemo");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("author");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OcSeoUrl>(entity =>
            {
                entity.HasKey(e => e.SeoUrlId)
                    .HasName("PK_oc_seo_url_seo_url_id");

                entity.ToTable("oc_seo_url", "storedemo");

                entity.HasIndex(e => e.Keyword, "keyword");

                entity.HasIndex(e => e.Query, "query");

                entity.Property(e => e.SeoUrlId).HasColumnName("seo_url_id");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("query");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_oc_session_session_id");

                entity.ToTable("oc_session", "storedemo");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .HasColumnName("session_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.Expire)
                    .HasPrecision(0)
                    .HasColumnName("expire");
            });

            modelBuilder.Entity<OcSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId)
                    .HasName("PK_oc_setting_setting_id");

                entity.ToTable("oc_setting", "storedemo");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("code");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("key");

                entity.Property(e => e.Serialized).HasColumnName("serialized");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcShippingCourier>(entity =>
            {
                entity.HasKey(e => e.ShippingCourierId)
                    .HasName("PK_oc_shipping_courier_shipping_courier_id");

                entity.ToTable("oc_shipping_courier", "storedemo");

                entity.Property(e => e.ShippingCourierId)
                    .ValueGeneratedNever()
                    .HasColumnName("shipping_courier_id");

                entity.Property(e => e.ShippingCourierCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shipping_courier_code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingCourierName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shipping_courier_name")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OcStatistic>(entity =>
            {
                entity.HasKey(e => e.StatisticsId)
                    .HasName("PK_oc_statistics_statistics_id");

                entity.ToTable("oc_statistics", "storedemo");

                entity.Property(e => e.StatisticsId).HasColumnName("statistics_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcStockStatus>(entity =>
            {
                entity.HasKey(e => new { e.StockStatusId, e.LanguageId })
                    .HasName("PK_oc_stock_status_stock_status_id");

                entity.ToTable("oc_stock_status", "storedemo");

                entity.Property(e => e.StockStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("stock_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcStore>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK_oc_store_store_id");

                entity.ToTable("oc_store", "storedemo");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Ssl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ssl");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<OcTaxClass>(entity =>
            {
                entity.HasKey(e => e.TaxClassId)
                    .HasName("PK_oc_tax_class_tax_class_id");

                entity.ToTable("oc_tax_class", "storedemo");

                entity.Property(e => e.TaxClassId).HasColumnName("tax_class_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcTaxRate>(entity =>
            {
                entity.HasKey(e => e.TaxRateId)
                    .HasName("PK_oc_tax_rate_tax_rate_id");

                entity.ToTable("oc_tax_rate", "storedemo");

                entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.GeoZoneId).HasColumnName("geo_zone_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("rate")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OcTaxRateToCustomerGroup>(entity =>
            {
                entity.HasKey(e => new { e.TaxRateId, e.CustomerGroupId })
                    .HasName("PK_oc_tax_rate_to_customer_group_tax_rate_id");

                entity.ToTable("oc_tax_rate_to_customer_group", "storedemo");

                entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");
            });

            modelBuilder.Entity<OcTaxRule>(entity =>
            {
                entity.HasKey(e => e.TaxRuleId)
                    .HasName("PK_oc_tax_rule_tax_rule_id");

                entity.ToTable("oc_tax_rule", "storedemo");

                entity.Property(e => e.TaxRuleId).HasColumnName("tax_rule_id");

                entity.Property(e => e.Based)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("based");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxClassId).HasColumnName("tax_class_id");

                entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
            });

            modelBuilder.Entity<OcTheme>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PK_oc_theme_theme_id");

                entity.ToTable("oc_theme", "storedemo");

                entity.Property(e => e.ThemeId).HasColumnName("theme_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("theme");
            });

            modelBuilder.Entity<OcTranslation>(entity =>
            {
                entity.HasKey(e => e.TranslationId)
                    .HasName("PK_oc_translation_translation_id");

                entity.ToTable("oc_translation", "storedemo");

                entity.Property(e => e.TranslationId).HasColumnName("translation_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("key");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcUpload>(entity =>
            {
                entity.HasKey(e => e.UploadId)
                    .HasName("PK_oc_upload_upload_id");

                entity.ToTable("oc_upload", "storedemo");

                entity.Property(e => e.UploadId).HasColumnName("upload_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_oc_user_user_id");

                entity.ToTable("oc_user", "storedemo");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("password");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("salt");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<OcUserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId)
                    .HasName("PK_oc_user_group_user_group_id");

                entity.ToTable("oc_user_group", "storedemo");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnName("permission");
            });

            modelBuilder.Entity<OcVoucher>(entity =>
            {
                entity.HasKey(e => e.VoucherId)
                    .HasName("PK_oc_voucher_voucher_id");

                entity.ToTable("oc_voucher", "storedemo");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.FromEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("from_email");

                entity.Property(e => e.FromName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("from_name");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ToEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("to_email");

                entity.Property(e => e.ToName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("to_name");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");
            });

            modelBuilder.Entity<OcVoucherHistory>(entity =>
            {
                entity.HasKey(e => e.VoucherHistoryId)
                    .HasName("PK_oc_voucher_history_voucher_history_id");

                entity.ToTable("oc_voucher_history", "storedemo");

                entity.Property(e => e.VoucherHistoryId).HasColumnName("voucher_history_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");
            });

            modelBuilder.Entity<OcVoucherTheme>(entity =>
            {
                entity.HasKey(e => e.VoucherThemeId)
                    .HasName("PK_oc_voucher_theme_voucher_theme_id");

                entity.ToTable("oc_voucher_theme", "storedemo");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<OcVoucherThemeDescription>(entity =>
            {
                entity.HasKey(e => new { e.VoucherThemeId, e.LanguageId })
                    .HasName("PK_oc_voucher_theme_description_voucher_theme_id");

                entity.ToTable("oc_voucher_theme_description", "storedemo");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcWeightClass>(entity =>
            {
                entity.HasKey(e => e.WeightClassId)
                    .HasName("PK_oc_weight_class_weight_class_id");

                entity.ToTable("oc_weight_class", "storedemo");

                entity.Property(e => e.WeightClassId).HasColumnName("weight_class_id");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15, 8)")
                    .HasColumnName("value")
                    .HasDefaultValueSql("((0.00000000))");
            });

            modelBuilder.Entity<OcWeightClassDescription>(entity =>
            {
                entity.HasKey(e => new { e.WeightClassId, e.LanguageId })
                    .HasName("PK_oc_weight_class_description_weight_class_id");

                entity.ToTable("oc_weight_class_description", "storedemo");

                entity.Property(e => e.WeightClassId).HasColumnName("weight_class_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<OcZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK_oc_zone_zone_id");

                entity.ToTable("oc_zone", "storedemo");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OcZoneToGeoZone>(entity =>
            {
                entity.HasKey(e => e.ZoneToGeoZoneId)
                    .HasName("PK_oc_zone_to_geo_zone_zone_to_geo_zone_id");

                entity.ToTable("oc_zone_to_geo_zone", "storedemo");

                entity.Property(e => e.ZoneToGeoZoneId).HasColumnName("zone_to_geo_zone_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.DateAdded)
                    .HasPrecision(0)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateModified)
                    .HasPrecision(0)
                    .HasColumnName("date_modified");

                entity.Property(e => e.GeoZoneId).HasColumnName("geo_zone_id");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
