﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventalinpromocione
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int Idpromocion { get; set; }
        public double? Importepromocion { get; set; }
        public double? Importepromocioniva { get; set; }

        public virtual Albventalin NNavigation { get; set; } = null!;
    }
}
