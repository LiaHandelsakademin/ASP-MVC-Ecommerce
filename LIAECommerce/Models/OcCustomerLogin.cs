﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcCustomerLogin
    {
        public int CustomerLoginId { get; set; }
        public string Email { get; set; }
        public string Ip { get; set; }
        public int Total { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
