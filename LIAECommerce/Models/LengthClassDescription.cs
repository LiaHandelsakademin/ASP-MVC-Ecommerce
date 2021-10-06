using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class LengthClassDescription
    {
        public int LengthClassId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
    }
}
