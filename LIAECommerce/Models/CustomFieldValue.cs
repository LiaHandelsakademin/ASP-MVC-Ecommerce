using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomFieldValue
    {
        public int CustomFieldValueId { get; set; }
        public int CustomFieldId { get; set; }
        public int SortOrder { get; set; }
    }
}
