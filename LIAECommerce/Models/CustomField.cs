using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomField
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
