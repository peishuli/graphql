using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class LinkType : ObjectGraphType<LinkDomainModel>
    {
        public LinkType()
        {
            Name = "Link";
            Description = "A link";
            Field(l => l.Href, nullable: false);
            Field(l => l.Media, nullable: true);
            Field(l => l.Type, nullable: true);
            Field(l => l.Rel, nullable: true);
        }
    }
}
