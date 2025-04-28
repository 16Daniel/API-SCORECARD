using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class AnulAlbventalin
    {
        public AnulAlbventalin()
        {
            AnulAlbventalinpromociones = new HashSet<AnulAlbventalinpromocione>();
        }

        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int? Codarticulo { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public string Color { get; set; } = null!;
        public string Talla { get; set; } = null!;
        public double? Unid1 { get; set; }
        public double? Unid2 { get; set; }
        public double? Unid3 { get; set; }
        public double? Unid4 { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Unidadespagadas { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public double? Total { get; set; }
        public double? Coste { get; set; }
        public double? Preciodefecto { get; set; }
        public short? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public int? Codtarifa { get; set; }
        public string? Codalmacen { get; set; }
        public string? Lineaoculta { get; set; }
        public double? Numkg { get; set; }
        public string? Prestamo { get; set; }
        public int? Codvendedor { get; set; }
        public string? Supedido { get; set; }
        public int? Contacto { get; set; }
        public double? Precioiva { get; set; }
        public int? Codformato { get; set; }
        public int? Codmacro { get; set; }
        public double? Udsexpansion { get; set; }
        public string? Expandida { get; set; }
        public double? Totalexpansion { get; set; }
        public double? Costeiva { get; set; }
        public string? Tipo { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public double? Comision { get; set; }
        public double Numkgexpansion { get; set; }
        public double? Cargo1 { get; set; }
        public double? Cargo2 { get; set; }
        public DateTime? Hora { get; set; }
        public double? Udsabonadas { get; set; }
        public string? AbonodeNumserie { get; set; }
        public int? AbonodeNumalbaran { get; set; }
        public string? AbonodeN { get; set; }
        public DateTime? Fechacaducidad { get; set; }
        public double? Udmedida2 { get; set; }
        public double? Udmedida2expansion { get; set; }
        public int? Idpromocion { get; set; }
        public double? Importeantespromocion { get; set; }
        public double? Importeantespromocioniva { get; set; }
        public double? Importepromocion { get; set; }
        public double? Importepromocioniva { get; set; }
        public double? Porcretencion { get; set; }
        public double? Dtoantespromocion { get; set; }

        public virtual AnulAlbventacab NNavigation { get; set; } = null!;
        public virtual ICollection<AnulAlbventalinpromocione> AnulAlbventalinpromociones { get; set; }
    }
}
