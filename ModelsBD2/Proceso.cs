using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Proceso
    {
        public Proceso()
        {
            Procesoslins = new HashSet<Procesoslin>();
        }

        public int Idproceso { get; set; }
        public string? Descripcion { get; set; }
        public int? Tipo { get; set; }
        public bool? Activo { get; set; }
        public int? Frecuencia { get; set; }
        public int? Xdias { get; set; }
        public DateTime? Hora { get; set; }
        public bool? Lunes { get; set; }
        public bool? Martes { get; set; }
        public bool? Miercoles { get; set; }
        public bool? Jueves { get; set; }
        public bool? Viernes { get; set; }
        public bool? Sabado { get; set; }
        public bool? Domingo { get; set; }
        public DateTime? Horalunes { get; set; }
        public DateTime? Horamartes { get; set; }
        public DateTime? Horamiercoles { get; set; }
        public DateTime? Horajueves { get; set; }
        public DateTime? Horaviernes { get; set; }
        public DateTime? Horasabado { get; set; }
        public DateTime? Horadomingo { get; set; }
        public DateTime? Nextejecucion { get; set; }
        public DateTime? Lastejecucion { get; set; }
        public int? Estado { get; set; }
        public string? Lastejecucionmsg { get; set; }
        public string? Terminalejecutante { get; set; }
        public string? Lastejecucionterminal { get; set; }
        public int? Xsegundos { get; set; }
        public string? Enhilosecundario { get; set; }
        public int? Tipoejecutante { get; set; }

        public virtual ICollection<Procesoslin> Procesoslins { get; set; }
    }
}
