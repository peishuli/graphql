using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class Project : ProjectBaseModel
    {
        public Project()
        {
            Sites = new HashSet<Site>();
        }

        public Customer Customer { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public ICollection<Site> Sites { get; set; }
    }
}
