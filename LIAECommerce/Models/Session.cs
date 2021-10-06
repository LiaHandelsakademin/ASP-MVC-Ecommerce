using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Session
    {
        public string SessionId { get; set; }
        public string Data { get; set; }
        public DateTime Expire { get; set; }
    }
}
