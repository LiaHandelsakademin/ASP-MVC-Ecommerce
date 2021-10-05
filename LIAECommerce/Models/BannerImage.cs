using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class BannerImage
    {
        public int banner_image_id { get; set; }
        public int banner_id { get; set; }
        public int language_id { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string image { get; set; }
        public int sort_order { get; set; }
    }
}
