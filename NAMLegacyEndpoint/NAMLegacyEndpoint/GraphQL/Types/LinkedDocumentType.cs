using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class LinkedDocumentType : ObjectGraphType<LinkedDocumentDomainModel>
    {
        public LinkedDocumentType()
        {
            Name = "LinkedDocument";
            Description = "a lined document";
            Field(l => l.DocumentId, nullable: false);
            Field(l => l.ContentType, nullable: true);
            Field(l => l.DocumentType, nullable: true);
        }
    }
}
