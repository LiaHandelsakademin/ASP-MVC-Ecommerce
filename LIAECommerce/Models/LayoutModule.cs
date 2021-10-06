using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class LayoutModule
    {
        public int LayoutModuleId { get; set; }
        public int LayoutId { get; set; }
        public string Code { get; set; }
        public string Position { get; set; }
        public int SortOrder { get; set; }
    }
}
