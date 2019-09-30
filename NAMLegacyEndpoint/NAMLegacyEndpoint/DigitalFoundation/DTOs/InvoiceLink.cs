namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class InvoiceLink
    {
        /// <summary>
        /// Link to the endpoint
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// Media type
        /// </summary>
        public string Media { get; set; }

        /// <summary>
        /// Indicating the type of document content
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Type of the relationship to the reference
        /// </summary>
        public string Rel { get; set; }
    }
}