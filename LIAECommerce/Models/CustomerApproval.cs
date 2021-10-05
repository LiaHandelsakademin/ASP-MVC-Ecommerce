using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerApproval
    {
        public int customer_approval_id { get; set; }
        public int customer_id { get; set; }
        public string type { get; set; }
        public DateTime date_added { get; set; }
    }
}
