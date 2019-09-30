using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using System;
using System.Collections.Generic;

namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class ProjectDomainModel : ProjectBaseModel
    {
        public ProjectDomainModel()
        {
            Sites = new HashSet<SiteDomainModel>();
        }

        public CustomerDomainModel Customer { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUct { get; set; }
        public ICollection<SiteDomainModel> Sites { get; set; }
    }
}
