using System;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class DeliveryEventDomainModel
    {
        public DateTime? LoadStartedUtc { get; set; }
        public DateTime? LoadFinishedUtc { get; set; }
        public DateTime? ArrivedUtc { get; set; }
        public DateTime? UnloadStartedUtc { get; set; }
        public DateTime? UnloadFinishedUtc { get; set; }
    }
}
