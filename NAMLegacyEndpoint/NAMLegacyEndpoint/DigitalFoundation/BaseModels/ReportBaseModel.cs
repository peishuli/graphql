namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class ReportBaseModel
    {
        public string CustomerId { get; set; }
        public string ProjectId { get; set; }
        public string SiteId { get; set; }
        public int ActiveCount { get; set; }
        public int DeliveredCount { get; set; }
        public int ConfirmedCount { get; set; }
        public int ReservedCount { get; set; }
        public int InProgressCount { get; set; }
        public int PartiallyDeliveredCount { get; set; }
        public int PartiallyShippedCount { get; set; }
        public int ShippedCount { get; set; }
        public int PendingCount { get; set; }
        public int TotalCount { get; set; }
        public override string ToString()
        {
            return $"{this.CustomerId} - {this.ProjectId} - {this.SiteId}";
        }
    }
}
