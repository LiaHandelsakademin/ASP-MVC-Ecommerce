using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class VoucherHistory
    {
        public int VoucherHistoryId { get; set; }
        public int VoucherId { get; set; }
        public Voucher Voucher { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
