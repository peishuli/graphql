namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public class InvoiceLineBaseModel
    {
        /// <summary>
        /// Reference to the position number of the row in the invoice
        /// </summary>
        public string ItemNumber { get; set; }
        /// <summary>
        /// Reference to business key of the material in the backend system
        /// </summary>
        public string MaterialNumber { get; set; }
        /// <summary>
        /// Description of the material of the order
        /// </summary>
        public string MaterialDescription { get; set; }
        /// <summary>
        /// Description of the material used by the customer
        /// </summary>
        public string CustomerMaterialDescription { get; set; }
        /// <summary>
        /// Customer reference text used by customer to identify the order, e.g. customer purchase order reference
        /// </summary>
        public string CustomerReference { get; set; }
        /// <summary>
        /// Quantity billed
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// The unit of measurement of the quantity order
        /// </summary>
        public string QuantityUom { get; set; }
        /// <summary>
        /// The net amount of the invoice item
        /// </summary>
        public decimal NetAmount { get; set; }
        /// <summary>
        /// The tax amount of the invoice item
        /// </summary>
        public decimal TaxAmount { get; set; }
        /// <summary>
        /// The net unit price of the item
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}