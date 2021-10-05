using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Upload
    {
        public int upload_id { get; set; }
        public string name { get; set; }
        public string filename { get; set; }
        public string code { get; set; }
        public DateTime date_added { get; set; }
    }
}
