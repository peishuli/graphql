using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class Schedule : ScheduleBaseModel
    {
        public string ScheduleStartDate { get; set; }
        public string ScheduleEndDate { get; set; }
        public string ArrivalSpacing { get; set; }
    }
}