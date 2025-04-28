using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mailingbitmap
    {
        public int Idinforme { get; set; }
        public int Idimagen { get; set; }
        public byte[]? Imagen { get; set; }
        public int? Banda { get; set; }
        public byte[]? Version { get; set; }
        public string? Hash { get; set; }

        public virtual Mailing IdinformeNavigation { get; set; } = null!;
    }
}
