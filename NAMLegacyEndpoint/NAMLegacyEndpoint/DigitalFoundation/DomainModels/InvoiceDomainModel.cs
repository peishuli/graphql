using System;
using System.Collections.Generic;
using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using HeidelbergCement.Foundation.Common.Interfaces.Enums;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class InvoiceDomainModel : InvoiceBaseModel
    {
        public DateTime? InvoiceDate { get; set; }
        public CustomerDomainModel Payer { get; set; }
        public CustomerDomainModel Customer { get; set; }
        public InvoiceType Type { get; set; }
        public InvoiceStatus Status { get; set; }
        public IEnumerable<InvoiceLineDomainModel> LineItems { get; set; }
        public IEnumerable<LinkedDocumentDomainModel> LinkedDocuments { get; set; }

        public InvoiceDomainModel()
        {
            LineItems = new HashSet<InvoiceLineDomainModel>();
            LinkedDocuments = new HashSet<LinkedDocumentDomainModel>();
        }
    }
}