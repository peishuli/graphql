using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class Report : ReportBaseModel
    {
        public Site Site { get; set; }
        public Project Project { get; set; }
    }
}
