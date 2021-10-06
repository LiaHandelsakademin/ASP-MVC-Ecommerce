using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Zone
    {
        public int ZoneId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public short Status { get; set; }
    }
}
