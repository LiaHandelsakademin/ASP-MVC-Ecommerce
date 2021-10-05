using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Translation
    {
        public int TranslationId { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Route { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
