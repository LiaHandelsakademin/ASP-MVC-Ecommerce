using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcEvent
    {
        public int EventId { get; set; }
        public string Code { get; set; }
        public string Trigger { get; set; }
        public string Action { get; set; }
        public short Status { get; set; }
        public int SortOrder { get; set; }
    }
}
