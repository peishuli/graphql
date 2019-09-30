using System;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class MillReportMetadataDomainModel
    {
        public string FileType { get; set; }
        public string DocumentTypeName { get; set; }
        public string Name { get; set; }
        public string DocumentId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateArchived { get; set; }
        public int PageCount { get; set; }
        public string SourceLocationName { get; set; }
        public string ProductTypeName { get; set; }
        public DateTime MillCertDate { get; set; }
    }
}