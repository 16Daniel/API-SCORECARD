﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Categorium
    {
        public int Codcategoria { get; set; }
        public string Descripcion { get; set; } = null!;
        public byte[]? Version { get; set; }
    }
}
