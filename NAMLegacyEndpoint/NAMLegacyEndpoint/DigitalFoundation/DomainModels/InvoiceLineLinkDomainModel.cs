using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using HeidelbergCement.Foundation.Common.Interfaces.Enums;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class InvoiceLineLinkDomainModel : InvoiceLineLinkBaseModel
    {
        /// <summary>
        /// Type of the relationship to the reference
        /// </summary>
        public InvoiceLineLinkRelType Rel { get; set; }
    }
}