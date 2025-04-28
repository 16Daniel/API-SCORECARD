using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Historicocoste
    {
        public DateTime Fecha { get; set; }
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Codalmacen { get; set; } = null!;
        public double Costemedio { get; set; }
        public double Costestock { get; set; }
        public double Ultimocoste { get; set; }
        public double Costemediodmn { get; set; }
        public double Costestockdmn { get; set; }
        public double Ultimocostedmn { get; set; }
        public double Costemedioreg { get; set; }
        public double Costestockreg { get; set; }
        public double Ultimocostereg { get; set; }
        public double Costemediodmnreg { get; set; }
        public double Costestockdmnreg { get; set; }
        public double Ultimocostedmnreg { get; set; }
        public bool Hayinventario { get; set; }
        public double Stockinicial { get; set; }
        public double Unidadescompradasinicial { get; set; }
        public double Compras { get; set; }
        public double Fabricados { get; set; }
        public double Trasprecibidos { get; set; }
        public double Ventas { get; set; }
        public double Consumos { get; set; }
        public double Usadosparafabricar { get; set; }
        public double Traspenviados { get; set; }
        public bool Recalcularcostes { get; set; }
        public bool Recalcularventas { get; set; }
        public double Comprasenstock { get; set; }
        public double Ventasenstock { get; set; }
        public double Usadosparafabricarenstock { get; set; }
        public bool Eskitsinstock { get; set; }
        public bool? Hayregulcostes { get; set; }
        public bool? Costesrecienasumidos { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
    }
}
