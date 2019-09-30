using System.Collections.Generic;
using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class InvoiceLine : InvoiceLineBaseModel
    {
        public IEnumerable<InvoiceLineLink> Links { get; set; }

        public InvoiceLine()
        {
            Links = new HashSet<InvoiceLineLink>();
        }
    }
}