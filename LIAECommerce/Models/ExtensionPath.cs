using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ExtensionPath
    {
        public int extension_PathId { get; set; }
        public int extension_install_id { get; set; }
        public string path { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
