using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Inventario
    {
        public Inventario()
        {
            Inventarioszonas = new HashSet<Inventarioszona>();
        }

        public DateTime Fecha { get; set; }
        public string Codalmacen { get; set; } = null!;
        public int? Tipovaloracion { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public int? Codvendedor { get; set; }
        public string? Completo { get; set; }
        public int? Metodo { get; set; }
        public string? Inicial { get; set; }
        public string? Bloqueado { get; set; }
        public int? Tipovaloraciondmn { get; set; }
        public short Estado { get; set; }
        public bool? Escierre { get; set; }
        public short? EnlaceEjercicio { get; set; }
        public short? EnlaceEmpresa { get; set; }
        public string? EnlaceUsuario { get; set; }
        public int? EnlaceAsiento { get; set; }

        public virtual ICollection<Inventarioszona> Inventarioszonas { get; set; }
    }
}
