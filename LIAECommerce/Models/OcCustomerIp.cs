﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcCustomerIp
    {
        public int CustomerIpId { get; set; }
        public int CustomerId { get; set; }
        public string Ip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
