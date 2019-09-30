using System;
using System.Collections.Generic;
using System.Text;

namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class MaterialCertificateBaseModel
    {
        public string MaterialCertificateId { get; set; }

        public string PlantId { get; set; }

        public string PlantName { get; set; }

        public string Type { get; set; }

        public string MaterialNumber { get; set; }

        public string MaterialDescription { get; set; }

        public string CertificationDate { get; set; }

        public override string ToString()
        {
            return $"{this.MaterialCertificateId}";
        }
    }

}
