using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Upload
    {
        public int UploadId { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
