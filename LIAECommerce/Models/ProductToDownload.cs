using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ProductToDownload
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DownloadId { get; set; }
        public Download Download { get; set; }
    }
}
