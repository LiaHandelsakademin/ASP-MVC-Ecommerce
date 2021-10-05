using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Country
    {
        public int country_id { get; set; }
        public string name { get; set; }
        public string iso_code_2 { get; set; }
        public string iso_code_3 { get; set; }
        public string address_format { get; set; }
        public short postcode_required { get; set; }
        public short status { get; set; }
    }
}
