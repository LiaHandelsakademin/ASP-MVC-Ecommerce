using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class LayoutRoute
    {
        public int layout_route_id { get; set; }
        public int layout_id { get; set; }
        public int store_id { get; set; }
        public string route { get; set; }
    }
}
