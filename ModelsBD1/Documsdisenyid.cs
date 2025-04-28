using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Documsdisenyid
    {
        public short Grupo { get; set; }
        public int Diseny { get; set; }
        public short Tipobanda { get; set; }
        public short Linea { get; set; }
        public short Columna { get; set; }
        public int Numeroelemento { get; set; }
        public short? Tamany { get; set; }
        public string? Alta { get; set; }
        public string? Ancha { get; set; }
        public string? Negrita { get; set; }
        public string? Cursiva { get; set; }
        public string? Subrallado { get; set; }
        public short? Tipo { get; set; }
        public int? Formato { get; set; }
        public int? Codtitulo { get; set; }
        public string? SecEscAnterior { get; set; }
        public string? SecEscPosterior { get; set; }
        public string? Valor { get; set; }

        public virtual Nombresdocsid Nombresdocsid { get; set; } = null!;
    }
}
