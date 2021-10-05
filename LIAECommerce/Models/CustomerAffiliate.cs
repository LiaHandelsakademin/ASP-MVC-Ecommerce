using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerAffiliate
    {
        public int customer_id { get; set; }
        public string company { get; set; }
        public string website { get; set; }
        public string tracking { get; set; }
        public decimal commission { get; set; }
        public string tax { get; set; }
        public string payment { get; set; }
        public string cheque { get; set; }
        public string paypal { get; set; }
        public string bank_name { get; set; }
        public string bank_branch_number { get; set; }
        public string bank_swift_code { get; set; }
        public string bank_account_name { get; set; }
        public string bank_account_number { get; set; }
        public string custom_field { get; set; }
        public short status { get; set; }
        public DateTime date_added { get; set; }
    }
}
