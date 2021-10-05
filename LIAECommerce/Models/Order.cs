using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Order
    {
        public int order_id { get; set; }
        public int invoice_no { get; set; }
        public string invoice_prefix { get; set; }
        public int store_id { get; set; }
        public string store_name { get; set; }
        public string store_url { get; set; }
        public int customer_id { get; set; }
        public int customer_group_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string custom_field { get; set; }
        public string payment_firstname { get; set; }
        public string payment_lastname { get; set; }
        public string payment_company { get; set; }
        public string payment_address_1 { get; set; }
        public string payment_address_2 { get; set; }
        public string payment_city { get; set; }
        public string payment_postcode { get; set; }
        public string payment_country { get; set; }
        public int payment_country_id { get; set; }
        public string payment_zone { get; set; }
        public int payment_zone_id { get; set; }
        public string payment_address_format { get; set; }
        public string payment_custom_field { get; set; }
        public string payment_method { get; set; }
        public string payment_code { get; set; }
        public string shipping_firstname { get; set; }
        public string shipping_lastname { get; set; }
        public string shipping_company { get; set; }
        public string shipping_address_1 { get; set; }
        public string shipping_address_2 { get; set; }
        public string shipping_city { get; set; }
        public string shipping_postcode { get; set; }
        public string shipping_country { get; set; }
        public int shipping_country_id { get; set; }
        public string shipping_zone { get; set; }
        public int shipping_zone_id { get; set; }
        public string shipping_address_format { get; set; }
        public string shipping_custom_field { get; set; }
        public string shipping_method { get; set; }
        public string shipping_code { get; set; }
        public string comment { get; set; }
        public decimal total { get; set; }
        public int order_status_id { get; set; }
        public int affiliate_id { get; set; }
        public decimal commission { get; set; }
        public int marketing_id { get; set; }
        public string tracking { get; set; }
        public int language_id { get; set; }
        public int currency_id { get; set; }
        public string currency_code { get; set; }
        public decimal currency_value { get; set; }
        public string ip { get; set; }
        public string forwarded_ip { get; set; }
        public string user_agent { get; set; }
        public string accept_language { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
