using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Remesa
    {
        public Remesa()
        {
            Remesasadeudos = new HashSet<Remesasadeudo>();
            Remesasvencimientos = new HashSet<Remesasvencimiento>();
        }

        public int Numeroremesa { get; set; }
        public DateTime? Fechaconfeccion { get; set; }
        public int? Norma { get; set; }
        public string? Contrapartida { get; set; }
        public int? Ejercicio { get; set; }
        public int? Codempresaconta { get; set; }
        public int? Asentamiento { get; set; }
        public string? Usuario { get; set; }
        public int? Codlineadesc { get; set; }
        public int? Tipoagrup { get; set; }
        public string? Codpais { get; set; }
        public int? Subnorma { get; set; }
        public int? Lineadescuento { get; set; }
        public string? Cuentalineadescuento { get; set; }

        public virtual ICollection<Remesasadeudo> Remesasadeudos { get; set; }
        public virtual ICollection<Remesasvencimiento> Remesasvencimientos { get; set; }
    }
}
