using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Download
    {
        public int download_id { get; set; }
        public string filename { get; set; }
        public string mask { get; set; }
        public DateTime date_added { get; set; }
    }
}
