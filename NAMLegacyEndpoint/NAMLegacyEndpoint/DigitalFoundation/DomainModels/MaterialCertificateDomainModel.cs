using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class MaterialCertificateDomainModel: MaterialCertificateBaseModel
    {
        public MaterialCertificateDomainModel()
        {
            Links = new HashSet<LinkDomainModel>();
        }
        public ICollection<LinkDomainModel> Links { get; set; }
    }
}
