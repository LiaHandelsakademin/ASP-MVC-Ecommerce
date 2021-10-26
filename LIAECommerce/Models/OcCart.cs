﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcCart
    {
        public long CartId { get; set; }
        public int ApiId { get; set; }
        public int CustomerId { get; set; }
        public string SessionId { get; set; }
        public int ProductId { get; set; }
        public int RecurringId { get; set; }
        public string Option { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
