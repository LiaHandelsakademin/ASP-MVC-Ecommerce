using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomerApproval
    {
        public int CustomerApprovalId { get; set; }
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
