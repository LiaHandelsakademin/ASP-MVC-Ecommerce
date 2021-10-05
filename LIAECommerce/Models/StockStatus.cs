using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class StockStatus
    {
        public int StockStatusId { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
