using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class LineItemType : ObjectGraphType<LineItemDomainModel>
    {
        public LineItemType()
        {
            Name = "LineItem";
            Description = "A line item";
            Field(l=> l.ItemNumber, nullable: false).Description("The site id");
            Field(l => l.MaterialNumber, nullable: true);
            Field(l => l.MaterialDescription, nullable: true);
            Field(l => l.CustomerMaterialDescription, nullable: true);           
            Field(l => l.Quantity, nullable: true, type: typeof(FloatGraphType));
            Field(l => l.QuantityUom, nullable: true);
            //TODO:
            Field(l => l.MaterialCharacteristics, nullable: true,
               type: typeof(ListGraphType<MaterialCharacteristicType>));



        }
    }
}
