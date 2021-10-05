using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Return
    {
        public int return_id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int customer_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string product { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public short opened { get; set; }
        public int return_reason_id { get; set; }
        public int return_action_id { get; set; }
        public int return_status_id { get; set; }
        public string comment { get; set; }
        public DateTime date_ordered { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }
}
