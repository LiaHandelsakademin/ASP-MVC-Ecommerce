﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LIAECommerce
{
    public partial class OcExtensionPath
    {
        public int ExtensionPathId { get; set; }
        public int ExtensionInstallId { get; set; }
        public string Path { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
