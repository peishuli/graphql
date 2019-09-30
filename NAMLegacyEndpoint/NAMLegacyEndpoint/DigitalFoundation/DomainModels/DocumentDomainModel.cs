namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class DocumentDomainModel
    {
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public byte[] Content { get; set; }
    }
}
