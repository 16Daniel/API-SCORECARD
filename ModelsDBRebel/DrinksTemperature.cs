using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class DrinksTemperature
    {
        public DrinksTemperature()
        {
            PhotoDrinksTemperatures = new HashSet<PhotoDrinksTemperature>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool LightBeer { get; set; }
        public bool DarkBeer { get; set; }
        public bool DrinkOne { get; set; }
        public bool DrinkTwo { get; set; }
        public bool DrinkThree { get; set; }
        public bool DrinkFour { get; set; }
        public bool DrinkFive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Chope { get; set; }

        public virtual ICollection<PhotoDrinksTemperature> PhotoDrinksTemperatures { get; set; }
    }
}
