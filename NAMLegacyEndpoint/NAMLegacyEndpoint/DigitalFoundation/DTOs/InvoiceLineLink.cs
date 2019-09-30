using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class InvoiceLineLink : InvoiceLineLinkBaseModel
    {
        /// <summary>
        /// Type of the relationship to the reference
        /// </summary>
        public string Rel { get; set; }
    }
}