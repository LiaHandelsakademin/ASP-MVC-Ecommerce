using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string IsoCode2 { get; set; }
        public string IsoCode3 { get; set; }
        public string AddressFormat { get; set; }
        public short PostcodeRequired { get; set; }
        public short Status { get; set; }
    }
}
