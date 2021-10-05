using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ReturnReason
    {
        public int return_reason_id { get; set; }
        public int language_id { get; set; }
        public string name { get; set; }
    }
}
