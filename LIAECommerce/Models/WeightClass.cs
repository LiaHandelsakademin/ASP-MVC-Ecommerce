using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class WeightClass
    {
        public int WeightClassId { get; set; }
        public decimal Value { get; set; }
        public ICollection<WeightClassDescription> WeightClassDescriptions { get; set; }
    }
}
