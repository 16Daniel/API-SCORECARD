﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class BiInformesUsuario
    {
        public int Idusuario { get; set; }
        public int Idinforme { get; set; }

        public virtual BiInforme IdinformeNavigation { get; set; } = null!;
    }
}
