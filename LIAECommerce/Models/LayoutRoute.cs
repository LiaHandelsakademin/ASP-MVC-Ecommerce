using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class LayoutRoute
    {
        public int LayoutRouteId { get; set; }
        public int LayoutId { get; set; }
        public int StoreId { get; set; }
        public string Route { get; set; }
    }
}
