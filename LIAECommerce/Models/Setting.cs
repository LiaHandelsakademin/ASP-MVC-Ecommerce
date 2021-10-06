using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Setting
    {
        public int SettingId { get; set; }
        public int StoreId { get; set; }
        public string Code { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public short Serialized { get; set; }
    }
}
