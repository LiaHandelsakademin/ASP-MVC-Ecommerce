using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcDownload
    {
        public int DownloadId { get; set; }
        public string Filename { get; set; }
        public string Mask { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
