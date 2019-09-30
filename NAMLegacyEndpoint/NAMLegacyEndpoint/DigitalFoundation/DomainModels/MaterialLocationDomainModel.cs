using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class MaterialLocationDomainModel : MaterialLocationBaseModel
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public DateTime? EstimatedTimeOfArrivalUtc { get; set; }
        public DateTime? LastUpdatedUtc { get; set; }
    }
}
