using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class Almacenaje
    {
        public int Id { get; set; }
        public int Idsucursal { get; set; }
        public int Codarticulo { get; set; }
        public double Capacidad { get; set; }
    }
}
