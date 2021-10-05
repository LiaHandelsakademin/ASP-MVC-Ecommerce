using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class User
    {
        public int user_id { get; set; }
        public int user_group_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string image { get; set; }
        public string code { get; set; }
        public string ip { get; set; }
        public short status { get; set; }
        public DateTime date_added { get; set; }
    }
}
