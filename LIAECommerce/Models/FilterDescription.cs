using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class FilterDescription
    {
        public int FilterId { get; set; }
        public int LanguageId { get; set; }
        public int FilterGroupId { get; set; }
        public string Name { get; set; }
    }
}
