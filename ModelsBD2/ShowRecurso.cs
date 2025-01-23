using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ShowRecurso
    {
        public ShowRecurso()
        {
            ShowItems = new HashSet<ShowItem>();
        }

        public int Idrecurso { get; set; }
        public short? Tiporecurso { get; set; }
        public byte[]? Bitmap { get; set; }
        public string? Texto { get; set; }
        public byte[]? Thumb { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<ShowItem> ShowItems { get; set; }
    }
}
