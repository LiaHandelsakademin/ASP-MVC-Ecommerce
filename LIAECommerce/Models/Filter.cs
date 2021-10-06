using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class Filter
    {
        public int FilterId { get; set; }
        public int FilterGroupId { get; set; }
        public int SortOrder { get; set; }
    }
}
