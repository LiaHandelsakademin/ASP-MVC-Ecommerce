using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ExtensionInstall
    {
        public int extension_install_id { get; set; }
        public int extension_download_id { get; set; }
        public string filename { get; set; }
        public DateTime date_added { get; set; }
    }
}
