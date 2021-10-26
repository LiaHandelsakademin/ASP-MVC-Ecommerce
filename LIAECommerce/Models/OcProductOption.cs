using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcProductOption
    {
        public int ProductOptionId { get; set; }
        public int ProductId { get; set; }
        public int OptionId { get; set; }
        public string Value { get; set; }
        public short Required { get; set; }
    }
}
