using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class InformationDescription
    {
        public int information_id { get; set; }
        public int LanguageId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}
