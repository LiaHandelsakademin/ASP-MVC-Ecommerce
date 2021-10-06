﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Code { get; set; }
        public string Trigger { get; set; }
        public string Action { get; set; }
        public short Status { get; set; }
        public int SortOrder { get; set; }
    }
}
