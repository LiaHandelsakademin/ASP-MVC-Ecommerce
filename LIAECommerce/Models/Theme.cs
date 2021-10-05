using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Theme
    {
        public int ThemeId { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public string ThemeName { get; set; }
        public string Route { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
