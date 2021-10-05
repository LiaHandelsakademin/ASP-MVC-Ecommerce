using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class VoucherThemeDescription
    {
        public int VoucherThemeId { get; set; }
        public VoucherTheme VoucherTheme { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
