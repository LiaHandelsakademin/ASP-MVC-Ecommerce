using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class RecurringDescription
    {
        public int RecurringId { get; set; }
        public Recurring Recurring { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
