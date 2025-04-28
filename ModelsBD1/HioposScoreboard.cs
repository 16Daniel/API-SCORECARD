using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class HioposScoreboard
    {
        public HioposScoreboard()
        {
            HioposScoreboardInformes = new HashSet<HioposScoreboardInforme>();
        }

        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int? Codusuario { get; set; }

        public virtual ICollection<HioposScoreboardInforme> HioposScoreboardInformes { get; set; }
    }
}
