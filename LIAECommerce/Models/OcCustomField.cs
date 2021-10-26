using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcCustomField
    {
        public int CustomFieldId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Validation { get; set; }
        public string Location { get; set; }
        public short Status { get; set; }
        public int SortOrder { get; set; }
    }
}
