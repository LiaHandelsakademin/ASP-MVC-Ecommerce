using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class LayoutRoute
    {
        public int layout_route_id { get; set; }
        public int LayoutId { get; set; }
        public int StoreId { get; set; }
        public string route { get; set; }
    }
}
