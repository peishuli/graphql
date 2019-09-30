using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using HeidelbergCement.Foundation.Common.Interfaces.Enums;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class Delivery : DeliveryBaseModel
    {
        public Delivery()
        {
            Links = new HashSet<Link>();
        }
        
        public DeliveryStatus DeliveryStatus { get; set; }
        public DeliveryEvent DeliveryEvents { get; set; }
        public ICollection<Link> Links { get; set; }
        public string ShippingType { get; set; }
        public string ShippingDate { get; set; }
    }
}
