using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcApi
    {
        public int ApiId { get; set; }
        public string Username { get; set; }
        public string Key { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
