using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Setting
    {
        public int setting_id { get; set; }
        public int store_id { get; set; }
        public string code { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        public short serialized { get; set; }
    }
}
