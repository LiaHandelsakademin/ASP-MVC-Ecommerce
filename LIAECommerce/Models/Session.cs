using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Session
    {
        public string session_id { get; set; }
        public string data { get; set; }
        public DateTime expire { get; set; }
    }
}
