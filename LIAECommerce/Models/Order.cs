using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int invoice_no { get; set; }
        public string invoice_prefix { get; set; }
        public int StoreId { get; set; }
        public string store_name { get; set; }
        public string store_url { get; set; }
        public int CustomerId { get; set; }
        public int CustomerGroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string custom_field { get; set; }
        public string payment_FirstName { get; set; }
        public string payment_LastName { get; set; }
        public string payment_company { get; set; }
        public string payment_address_1 { get; set; }
        public string payment_address_2 { get; set; }
        public string payment_city { get; set; }
        public string payment_postcode { get; set; }
        public string payment_country { get; set; }
        public int payment_CountryId { get; set; }
        public string payment_zone { get; set; }
        public int payment_zone_id { get; set; }
        public string payment_AddressFormat { get; set; }
        public string payment_custom_field { get; set; }
        public string payment_method { get; set; }
        public string payment_code { get; set; }
        public string Shipping_FirstName { get; set; }
        public string Shipping_LastName { get; set; }
        public string Shipping_company { get; set; }
        public string Shipping_address_1 { get; set; }
        public string Shipping_address_2 { get; set; }
        public string Shipping_city { get; set; }
        public string Shipping_postcode { get; set; }
        public string Shipping_country { get; set; }
        public int Shipping_CountryId { get; set; }
        public string Shipping_zone { get; set; }
        public int Shipping_zone_id { get; set; }
        public string Shipping_AddressFormat { get; set; }
        public string Shipping_custom_field { get; set; }
        public string Shipping_method { get; set; }
        public string Shipping_code { get; set; }
        public string comment { get; set; }
        public decimal total { get; set; }
        public int order_status_id { get; set; }
        public int affiliate_id { get; set; }
        public decimal commission { get; set; }
        public int marketing_id { get; set; }
        public string tracking { get; set; }
        public int LanguageId { get; set; }
        public int CurrencyId { get; set; }
        public string currency_code { get; set; }
        public decimal currency_value { get; set; }
        public string ip { get; set; }
        public string forwarded_ip { get; set; }
        public string user_agent { get; set; }
        public string accept_language { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
