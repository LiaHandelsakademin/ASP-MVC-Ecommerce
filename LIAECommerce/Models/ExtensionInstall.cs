using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class ExtensionInstall
    {
        public int ExtensionInstallId { get; set; }
        public int ExtensionDownloadId { get; set; }
        public string Filename { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
