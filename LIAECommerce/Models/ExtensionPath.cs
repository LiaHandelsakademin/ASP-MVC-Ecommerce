using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class ExtensionPath
    {
        public int ExtensionPathId { get; set; }
        public int ExtensionInstallId { get; set; }
        public string Path { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
