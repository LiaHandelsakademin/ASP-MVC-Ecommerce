using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Currency
    {
        public int currency_id { get; set; }
        public string title { get; set; }
        public string code { get; set; }
        public string symbol_left { get; set; }
        public string symbol_right { get; set; }
        public string decimal_place { get; set; }
        public decimal value { get; set; }
        public short status { get; set; }
        public DateTime date_modified { get; set; }
    }
}
