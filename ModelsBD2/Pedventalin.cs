using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Pedventalin
    {
        public Pedventalin()
        {
            Pedventalinpromociones = new HashSet<Pedventalinpromocione>();
        }

        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int? Codarticulo { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Unid1 { get; set; }
        public double? Unid2 { get; set; }
        public double? Unid3 { get; set; }
        public double? Unid4 { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Unidadespen { get; set; }
        public double? Unidadesrec { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public double? Total { get; set; }
        public double? Preciodefecto { get; set; }
        public short? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public string? Codalmacen { get; set; }
        public double? Numkg { get; set; }
        public string? Prestamo { get; set; }
        public double? Coste { get; set; }
        public int? Codtarifa { get; set; }
        public int? Codvendedor { get; set; }
        public double? Costeiva { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public string? Comentario { get; set; }
        public int? Codenvio { get; set; }
        public double? Cargo1 { get; set; }
        public double? Cargo2 { get; set; }
        public double? Udmedida2 { get; set; }
        public int? Idmotivodto { get; set; }
        public string? Lineaoculta { get; set; }
        public int? Codformato { get; set; }
        public int? Codmacro { get; set; }
        public double? Udspedidas { get; set; }
        public double? Pesounitario { get; set; }
        public bool? Impreso { get; set; }
        public double? Importeantespromocion { get; set; }
        public double? Importeantespromocioniva { get; set; }
        public double? Dtoantespromocion { get; set; }
        public int? Tarifaantespromocion { get; set; }

        public virtual Pedventacab NNavigation { get; set; } = null!;
        public virtual ICollection<Pedventalinpromocione> Pedventalinpromociones { get; set; }
    }
}
