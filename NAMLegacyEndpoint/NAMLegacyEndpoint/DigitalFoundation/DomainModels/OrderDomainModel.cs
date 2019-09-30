using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class OrderDomainModel : OrderBaseModel
    {
        public OrderDomainModel()
        {
            LineItems = new HashSet<LineItemDomainModel>();
            SupplementItems = new HashSet<SupplementItemDomainModel>();
            Schedules = new HashSet<ScheduleDomainModel>();
        }
        
        public CustomerDomainModel Customer { get; set; }
        public DateTime? ShippingDateUtc { get; set; }
        public DateTime? PlacedDateUtc { get; set; }
        public SiteDomainModel ShippingAddress { get; set; }
        public ICollection<LineItemDomainModel> LineItems { get; set; }
        public ICollection<SupplementItemDomainModel> SupplementItems { get; set; }
        public ICollection<ScheduleDomainModel> Schedules { get; set; }
        public ICollection<DeliveryDomainModel> Deliveries { get; set; }
        public DeliveryProgressDomainModel DeliveryProgress { get; set; }
    }
}
