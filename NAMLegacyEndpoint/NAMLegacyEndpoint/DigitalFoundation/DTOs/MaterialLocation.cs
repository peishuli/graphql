using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class MaterialLocation : MaterialLocationBaseModel
    {
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string EstimatedTimeOfArrival { get; set; }
        public string LastUpdated { get; set; }
    }
}
