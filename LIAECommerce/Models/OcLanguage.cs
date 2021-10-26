using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcLanguage
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Locale { get; set; }
        public string Image { get; set; }
        public string Directory { get; set; }
        public int SortOrder { get; set; }
        public short Status { get; set; }
    }
}
