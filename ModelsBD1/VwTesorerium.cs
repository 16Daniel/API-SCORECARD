using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class VwTesorerium
    {
        public string? Origen { get; set; }
        public string? Tipodocumento { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public string? N { get; set; }
        public short? Posicion { get; set; }
        public DateTime? Fechadocumento { get; set; }
        public DateTime? Fechavencimiento { get; set; }
        public string? Reposicion { get; set; }
        public string? Cuenta { get; set; }
        public int? Codigointerno { get; set; }
        public double? Importe { get; set; }
        public string? Contrapartida { get; set; }
        public string? Marcaborrado { get; set; }
        public string? Codformapago { get; set; }
        public string? Codtipopago { get; set; }
        public string? Estado { get; set; }
        public string? Comentario { get; set; }
        public int? Numeroremesa { get; set; }
        public string? Impreso { get; set; }
        public string? Traspasado { get; set; }
        public DateTime? Fechatraspaso { get; set; }
        public DateTime? Fechacartera { get; set; }
        public DateTime? Fechadescontado { get; set; }
        public DateTime? Fechasaldado { get; set; }
        public DateTime? Fechadevuelto { get; set; }
        public double? Importegastos { get; set; }
        public string? Cuentagastos { get; set; }
        public short? EnlaceEjercicio { get; set; }
        public short? EnlaceEmpresa { get; set; }
        public string? EnlaceUsuario { get; set; }
        public int? EnlaceAsiento { get; set; }
        public int? EnlaceApunte { get; set; }
        public string? Fechadirecta { get; set; }
        public string? Genapunte { get; set; }
        public double? Factormoneda { get; set; }
        public int? Codmoneda { get; set; }
        public string? Sudocumento { get; set; }
        public string? Multiple { get; set; }
        public string? Numefecto { get; set; }
        public string? Cuentapuente { get; set; }
        public double? Mora { get; set; }
        public int? Zsaldado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public string? Cajasaldado { get; set; }
        public double? Descuadre { get; set; }
        public string? Bloqueado { get; set; }
        public int? Compensacion { get; set; }
        public string? Comentariovisible { get; set; }
        public string? Serierecibo { get; set; }
        public int? Numrecibo { get; set; }
    }
}
