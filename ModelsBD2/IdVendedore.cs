﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IdVendedore
    {
        public int Codvendedor { get; set; }
        public Guid Guidvendedor { get; set; }

        public virtual Vendedore CodvendedorNavigation { get; set; } = null!;
    }
}
