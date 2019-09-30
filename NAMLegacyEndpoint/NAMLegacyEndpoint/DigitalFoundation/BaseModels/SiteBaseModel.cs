namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class SiteBaseModel
    {
        public string SiteId { get; set; }
        public string SiteNumber { get; set; }
        public string CustomerId { get; set; }
        public string SiteName { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{this.SiteId} - {this.SiteNumber} - {this.SiteName}";
        }
    }
}
