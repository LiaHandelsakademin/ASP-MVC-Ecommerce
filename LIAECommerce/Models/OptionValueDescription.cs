using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class OptionValueDescription
    {
        public int OptionValueId { get; set; }
        public int LanguageId { get; set; }
        public int OptionId { get; set; }
        public string Name { get; set; }
    }
}
