﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemCajasfrontsseriessubempresa
    {
        public int Idfront { get; set; }
        public int Cajafront { get; set; }
        public int Subempresa { get; set; }
        public int Tipodoc { get; set; }
        public string? Serie { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
