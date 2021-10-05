using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class VoucherHistory
    {
        public int voucher_history_id { get; set; }
        public int voucher_id { get; set; }
        public int order_id { get; set; }
        public decimal amount { get; set; }
        public DateTime date_added { get; set; }
    }
}
