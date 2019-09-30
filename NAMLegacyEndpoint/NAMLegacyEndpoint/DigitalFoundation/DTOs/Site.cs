using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class Site : SiteBaseModel
    {
        public string Lat { get; set; }
        public string Lng { get; set; }
    }
}
