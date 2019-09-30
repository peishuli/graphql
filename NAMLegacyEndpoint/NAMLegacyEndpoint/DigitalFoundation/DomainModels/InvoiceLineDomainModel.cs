using System.Collections.Generic;
using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class InvoiceLineDomainModel : InvoiceLineBaseModel
    {
        public IEnumerable<InvoiceLineLinkDomainModel> Links { get; set; }

        public InvoiceLineDomainModel()
        {
            Links = new HashSet<InvoiceLineLinkDomainModel>();
        }
    }
}