using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.BaseModels;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class SiteType : ObjectGraphType<SiteDomainModel>
    {
        public SiteType()
        {
            Name = "Site";
            Description = "A site";
            Field(s => s.SiteId, nullable: false).Description("The site id");
            Field(s => s.SiteNumber, nullable: false);
            Field(s => s.CustomerId, nullable: false);
            Field(s => s.SiteName, nullable: false);
            Field(s => s.Street, nullable: false);
            Field(s => s.PostalCode, nullable: false);
            Field(s => s.City, nullable: false);
            Field(s => s.State, nullable: false);
            Field(s => s.Country, nullable: false);
            //TODO:
            //Field(s => s.Lat, nullable: false);
            //Field(s => s.Lng, nullable: false);
        }
    }
}
