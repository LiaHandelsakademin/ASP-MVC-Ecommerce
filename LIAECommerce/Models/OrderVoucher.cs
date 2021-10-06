using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class OrderVoucher
    {
        public int OrderVoucherId { get; set; }
        public int OrderId { get; set; }
        public int VoucherId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public int VoucherThemeId { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
    }
}
