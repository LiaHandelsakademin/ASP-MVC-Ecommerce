using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class ReturnHistory
    {
        public int return_history_id { get; set; }
        public int return_id { get; set; }
        public int return_status_id { get; set; }
        public short notify { get; set; }
        public string comment { get; set; }
        public DateTime date_added { get; set; }
    }
}
