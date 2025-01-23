using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Kitchen
    {
        public Kitchen()
        {
            PhotoKitchens = new HashSet<PhotoKitchen>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool Sink { get; set; }
        public string? CommentSink { get; set; }
        public bool Mixer { get; set; }
        public string? CommentMixer { get; set; }
        public bool Strainer { get; set; }
        public string? CommentStrainer { get; set; }
        public bool Fryer { get; set; }
        public string? CommentFryer { get; set; }
        public bool Extractor { get; set; }
        public string? CommentExtractor { get; set; }
        public bool Refrigerator { get; set; }
        public string? CommentRefrigerator { get; set; }
        public bool InteriorTemperature { get; set; }
        public string? CommentInteriorTemperature { get; set; }
        public bool Doors { get; set; }
        public string? CommentDoors { get; set; }
        public bool CorrectDistance { get; set; }
        public string? CommentCorrectDistance { get; set; }
        public bool ElectricalConnections { get; set; }
        public string? CommentElectricalConnections { get; set; }
        public bool Luminaires { get; set; }
        public string? CommentLuminaires { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoKitchen> PhotoKitchens { get; set; }
    }
}
