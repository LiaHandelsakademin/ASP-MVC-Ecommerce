using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class CustomFieldValueDescription
    {
        public int CustomFieldValueId { get; set; }
        public int LanguageId { get; set; }
        public int CustomFieldId { get; set; }
        public string Name { get; set; }
    }
}
