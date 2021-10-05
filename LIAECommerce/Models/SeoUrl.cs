using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class SeoUrl
    {
        public int SeoUrlId { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Query { get; set; }
        public string Keyword { get; set; }
    }
}
