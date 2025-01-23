using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class HioposScoreboardInforme
    {
        public int Id { get; set; }
        public int Idinforme { get; set; }
        public int Posicion { get; set; }

        public virtual HioposScoreboard IdNavigation { get; set; } = null!;
    }
}
