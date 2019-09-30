using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class LineItem : LineItemBaseModel
    {
        public LineItem()
        {
            MaterialAttributes = new HashSet<MaterialAttribute>();
        }

        public ICollection<MaterialAttribute> MaterialAttributes { get; set; }
        
    }
}