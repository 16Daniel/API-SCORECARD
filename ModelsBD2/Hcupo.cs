using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hcupo
    {
        public Hcupo()
        {
            Hcuposclientes = new HashSet<Hcuposcliente>();
            Hcuposcomentarios = new HashSet<Hcuposcomentario>();
            Hcuposestadosdefectos = new HashSet<Hcuposestadosdefecto>();
            Hcuposextras = new HashSet<Hcuposextra>();
            Hcuposfechas = new HashSet<Hcuposfecha>();
            Hcuposrestricciones = new HashSet<Hcuposrestriccione>();
            Hcuposservicios = new HashSet<Hcuposservicio>();
            Hcupostipohabitacions = new HashSet<Hcupostipohabitacion>();
        }

        public int Idcupo { get; set; }
        public string Nombre { get; set; } = null!;
        public int Idhotel { get; set; }
        public int Codintermediario { get; set; }
        public int? Tipocupo { get; set; }
        public int Release { get; set; }
        public int? Tiporelease { get; set; }
        public int Contratado { get; set; }
        public int Estanciaminima { get; set; }
        public int? Idtarifa { get; set; }
        public bool Afectabooking { get; set; }
        public bool Garantizado { get; set; }
        public int? Tipohabitacion { get; set; }
        public bool Descatalogado { get; set; }
        public byte Pendientedescarga { get; set; }
        public int Diascancelacion { get; set; }
        public int? Posicionweb { get; set; }
        public short Tipo { get; set; }
        public bool Visibleweb { get; set; }
        public int? Estanciamaxima { get; set; }
        public bool? D1 { get; set; }
        public bool? D2 { get; set; }
        public bool? D3 { get; set; }
        public bool? D4 { get; set; }
        public bool? D5 { get; set; }
        public bool? D6 { get; set; }
        public bool? D7 { get; set; }
        public string? Codigopromocional { get; set; }
        public short? Tipopagocta { get; set; }
        public double? Porcacta { get; set; }
        public bool? Disponibilidadtiemporeal { get; set; }
        public bool? Cupositeminder { get; set; }

        public virtual ICollection<Hcuposcliente> Hcuposclientes { get; set; }
        public virtual ICollection<Hcuposcomentario> Hcuposcomentarios { get; set; }
        public virtual ICollection<Hcuposestadosdefecto> Hcuposestadosdefectos { get; set; }
        public virtual ICollection<Hcuposextra> Hcuposextras { get; set; }
        public virtual ICollection<Hcuposfecha> Hcuposfechas { get; set; }
        public virtual ICollection<Hcuposrestriccione> Hcuposrestricciones { get; set; }
        public virtual ICollection<Hcuposservicio> Hcuposservicios { get; set; }
        public virtual ICollection<Hcupostipohabitacion> Hcupostipohabitacions { get; set; }
    }
}
