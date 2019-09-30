using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class LineItemDomainModel : LineItemBaseModel
    {
        public LineItemDomainModel()
        {
            MaterialCharacteristics = new HashSet<MaterialCharacteristicDomainModel>();            
        }

        public ICollection<MaterialCharacteristicDomainModel> MaterialCharacteristics { get; set; }
    }
}
