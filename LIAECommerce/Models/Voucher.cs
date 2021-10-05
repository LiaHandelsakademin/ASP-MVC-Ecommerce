using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string Code { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public int VoucherThemeId { get; set; }
        public VoucherTheme VoucherTheme { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
        public ICollection<VoucherHistory> VoucherHistory { get; set; }
        public ICollection<OrderVoucher> OrderVouchers { get; set; }
    }
}
