using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class Order : OrderBaseModel
    {
        public Order()
        {
            LineItems = new HashSet<LineItem>();
            SupplementItems = new HashSet<SupplementItem>();
            Schedules = new HashSet<Schedule>();
            Deliveries = new HashSet<Delivery>();
        }

        public Customer Customer { get; set; }
        public string ShippingDate { get; set; }
        public string PlacedDate { get; set; }
        public Site ShippingAddress { get; set; }
        public ICollection<LineItem> LineItems { get; set; }
        public ICollection<SupplementItem> SupplementItems { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<Delivery> Deliveries { get; set; }
        public DeliveryProgress DeliveryProgress { get; set; }
    }
}
