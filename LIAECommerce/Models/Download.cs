using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class Download
    {
        public int DownloadId { get; set; }
        public string Filename { get; set; }
        public string mask { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
