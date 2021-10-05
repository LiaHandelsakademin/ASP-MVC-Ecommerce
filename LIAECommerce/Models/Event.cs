using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Event
    {
        public int event_id { get; set; }
        public string code { get; set; }
        public string trigger { get; set; }
        public string action { get; set; }
        public short status { get; set; }
        public int sort_order { get; set; }
    }
}
