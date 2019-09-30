using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using HeidelbergCement.Foundation.Common.Interfaces.Enums;
using System;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class DeliveryDomainModel : DeliveryBaseModel
    {
        public DeliveryDomainModel()
        {
            LinkedDocuments = new HashSet<LinkedDocumentDomainModel>();
            Links = new HashSet<LinkDomainModel>();
        }

        public DeliveryStatus DeliveryStatus { get; set; }
        public DeliveryEventDomainModel DeliveryEvents { get; set; }
        public ICollection<LinkedDocumentDomainModel> LinkedDocuments { get; set; }
        public ICollection<LinkDomainModel> Links { get; set; }
        public string ShippingType { get; set; }
        public DateTime? ShippingDateUtc { get; set; }
    }
}
