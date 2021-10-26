using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcReturnHistory
    {
        public int ReturnHistoryId { get; set; }
        public int ReturnId { get; set; }
        public int ReturnStatusId { get; set; }
        public short Notify { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
