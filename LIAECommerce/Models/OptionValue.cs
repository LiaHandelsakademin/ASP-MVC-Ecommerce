using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class OptionValue
    {
        public int OptionValueId { get; set; }
        public int OptionId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
