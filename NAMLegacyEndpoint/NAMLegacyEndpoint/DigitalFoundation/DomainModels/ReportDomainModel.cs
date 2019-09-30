using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class ReportDomainModel : ReportBaseModel
    {
        public ProjectDomainModel Project { get; set; }
        public SiteDomainModel Site { get; set; }
    }
}
