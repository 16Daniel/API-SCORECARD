﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Albcompralin
    {
        public Albcompralin()
        {
            Albcompragastos = new HashSet<Albcompragasto>();
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
        public short? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Numkg { get; set; }
        public string? Codalmacen { get; set; }
        public string? Deposito { get; set; }
        public double? Precioventa { get; set; }
        public string? Usarcoltallas { get; set; }
        public double? Importegastos { get; set; }
        public double? Udsexpansion { get; set; }
        public string? Expandida { get; set; }
        public double? Totalexpansion { get; set; }
        public string? Supedido { get; set; }
        public int? Codcliente { get; set; }
        public double Numkgexpansion { get; set; }
        public double? Cargo1 { get; set; }
        public double? Cargo2 { get; set; }
        public string? Dtotexto { get; set; }
        public string? Esoferta { get; set; }
        public int? Codenvio { get; set; }
        public double? Udmedida2 { get; set; }
        public double? Udmedida2expansion { get; set; }
        public double? Porcretencion { get; set; }
        public int? Tiporetencion { get; set; }
        public double? Udsabonadas { get; set; }
        public string? AbonodeNumserie { get; set; }
        public int? AbonodeNumalbaran { get; set; }
        public string? AbonodeN { get; set; }
        public double? Importecargo1 { get; set; }
        public double? Importecargo2 { get; set; }
        public string? Lineaoculta { get; set; }
        public int? Idmotivo { get; set; }
        public int? Codformato { get; set; }
        public int? Codmacro { get; set; }

        public virtual Albcompracab NNavigation { get; set; } = null!;
        public virtual ICollection<Albcompragasto> Albcompragastos { get; set; }
    }
}
