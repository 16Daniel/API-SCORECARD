using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class VendedoresplanE
    {
        public int Codvendedor { get; set; }
        public string Codalmacen { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime Planinicio { get; set; }
        public DateTime Planfin { get; set; }
        public int Planhoras { get; set; }
        public DateTime Realinicio { get; set; }
        public DateTime Realfin { get; set; }
        public int Realhoras { get; set; }
        public int Diferenciapos { get; set; }
        public int Diferencianeg { get; set; }
        public DateTime Inciinicio { get; set; }
        public DateTime Incifin { get; set; }
        public int Incihoras { get; set; }
        public int Codpermiso { get; set; }
        public string Observaciones { get; set; } = null!;
        public int Codtipoincidencia { get; set; }
        public int Repetido { get; set; }
        public int Borrar { get; set; }
        public int Codcategoria { get; set; }
    }
}
