using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class SupplementItemType : ObjectGraphType<SupplementItemDomainModel>
    {
        public SupplementItemType()
        {
            Name = "SupplementItem";
            Description = "A supplement item";
            Field(s => s.RelatedItemNumber, nullable: true);
            Field(s => s.ItemNumber, nullable: true);
            Field(s => s.ItemName, nullable: true);
            Field(s => s.Quantity, nullable: true, type: typeof(FloatGraphType));
            Field(s => s.QuantityUom, nullable: true);
        }
    }
}
