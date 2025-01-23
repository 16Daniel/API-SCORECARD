using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class ItTiempo
    {
        public int Id { get; set; }
        public int Idcomanda { get; set; }
        public int Codarticulo { get; set; }
        public int Orden { get; set; }
        public int Posicion { get; set; }
        public string Terminal { get; set; } = null!;
        public DateTime Hora { get; set; }
        public string Descripcion { get; set; } = null!;
        public double Unidades { get; set; }
        public double Minutos { get; set; }
        public string Entiempo { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
    }
}
