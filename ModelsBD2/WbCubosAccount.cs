using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class WbCubosAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
