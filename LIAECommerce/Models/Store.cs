using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Ssl { get; set; }
        public ICollection<ManufacturerToStore> Manufacturers { get; set; }
        public ICollection<ProductToStore> Products { get; set; }
        public ICollection<CategoryToStore> Categories { get; set; }
        public ICollection<Setting> Settings { get; set; }
        public ICollection<Theme> Themes { get; set; }

    }
}
