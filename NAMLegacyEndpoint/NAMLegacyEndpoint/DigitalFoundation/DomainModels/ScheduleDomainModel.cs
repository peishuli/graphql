using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class ScheduleDomainModel : ScheduleBaseModel
    {
        public DateTime? ScheduleStartDateUtc { get; set; }
        public DateTime? ScheduleEndDateUtc { get; set; }
        public int ArrivalSpacing { get; set; }
    }
}
