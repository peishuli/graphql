namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public class InvoiceBaseModel
    {
        public string InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceCurrency { get; set; }
        public decimal InvoiceNetValue { get; set; }
        public decimal InvoiceTaxValue { get; set; }
        public string CustomerReference { get; set; }
    }
}