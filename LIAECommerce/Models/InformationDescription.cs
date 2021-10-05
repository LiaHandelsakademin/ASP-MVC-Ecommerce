using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class InformationDescription
    {
        public int information_id { get; set; }
        public int language_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string meta_title { get; set; }
        public string meta_description { get; set; }
        public string meta_keyword { get; set; }
    }
}
