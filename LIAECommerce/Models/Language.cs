using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string locale { get; set; }
        public string image { get; set; }
        public string directory { get; set; }
        public int SortOrder { get; set; }
        public short status { get; set; }
    }
}
