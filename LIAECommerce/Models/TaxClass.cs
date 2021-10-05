using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class TaxClass
    {
        public int TaxClassId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<TaxRule> TaxRules { get; set; }
    }
}
