using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class SiteDomainModel : SiteBaseModel
    {
        
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        
    }
}