using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ReturnHistory
    {
        public int ReturnHistoryId { get; set; }
        public int ReturnId { get; set; }
        public int ReturnStatusId { get; set; }
        public short Notify { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
