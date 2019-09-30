using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class LineItemBaseModel
    {
        public string ItemNumber { get; set; }
        public string MaterialNumber { get; set; }
        public string MaterialDescription { get; set; }
        public string CustomerMaterialDescription { get; set; }
        //public decimal Quantity { get; set; }
        public float Quantity { get; set; }
        public string QuantityUom { get; set; }

        public override string ToString()
        {
            return $"{this.ItemNumber} - {this.MaterialNumber}";
        }
       
    }
}
