using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeDimensionesCubo
    {
        public int IdDimension { get; set; }
        public int IdCubo { get; set; }
        public bool? Generar { get; set; }

        public virtual IeCubo IdCuboNavigation { get; set; } = null!;
        public virtual IeDimensione IdDimensionNavigation { get; set; } = null!;
    }
}
