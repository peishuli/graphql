using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class MaterialCertificate: MaterialCertificateBaseModel
    {
        public MaterialCertificate()
        {
            Links = new HashSet<Link>();
        }

        public string CountryId { get; set; }
        public string BusinessLineId{ get; set; }
        public string materialName { get; set; }
        public ICollection<Link> Links { get; set; }
    }
}
