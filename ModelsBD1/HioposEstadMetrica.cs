﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class HioposEstadMetrica
    {
        public int Id { get; set; }
        public int Metrica { get; set; }

        public virtual HioposEstad IdNavigation { get; set; } = null!;
    }
}
