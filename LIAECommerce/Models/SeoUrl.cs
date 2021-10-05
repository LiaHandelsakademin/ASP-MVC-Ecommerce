using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class SeoUrl
    {
        public int seo_url_id { get; set; }
        public int store_id { get; set; }
        public int language_id { get; set; }
        public string query { get; set; }
        public string keyword { get; set; }
    }
}
