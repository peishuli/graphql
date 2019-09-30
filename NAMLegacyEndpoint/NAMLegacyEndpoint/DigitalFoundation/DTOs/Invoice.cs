using System.Collections.Generic;
using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class Invoice : InvoiceBaseModel
    {
        public string InvoiceDate { get; set; }
        public Customer Payer { get; set; }
        public Customer Customer { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public IEnumerable<InvoiceLine> LineItems { get; set; }
        public IEnumerable<InvoiceLink> Links { get; set; }

        public Invoice()
        {
            LineItems = new HashSet<InvoiceLine>();
            Links =  new HashSet<InvoiceLink>();
        }
    }
}