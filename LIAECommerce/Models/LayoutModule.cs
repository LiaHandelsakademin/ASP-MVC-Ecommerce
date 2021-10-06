using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class LayoutModule
    {
        public int layout_module_id { get; set; }
        public int LayoutId { get; set; }
        public string code { get; set; }
        public string position { get; set; }
        public int SortOrder { get; set; }
    }
}
