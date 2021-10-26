using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcCustomFieldCustomerGroup
    {
        public int CustomFieldId { get; set; }
        public int CustomerGroupId { get; set; }
        public short Required { get; set; }
    }
}
