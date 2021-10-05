using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Modification
    {
        public int modification_id { get; set; }
        public int extension_install_id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string author { get; set; }
        public string version { get; set; }
        public string link { get; set; }
        public string xml { get; set; }
        public short status { get; set; }
        public DateTime date_added { get; set; }
    }
}
