using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Fotoshotel
    {
        public int Idhotel { get; set; }
        public Guid Idfoto { get; set; }
        public byte[] Version { get; set; } = null!;
    }
}
