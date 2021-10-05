using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ReturnReason
    {
        public int ReturnReasonId { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
