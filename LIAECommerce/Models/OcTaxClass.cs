using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcTaxClass
    {
        public int TaxClassId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
