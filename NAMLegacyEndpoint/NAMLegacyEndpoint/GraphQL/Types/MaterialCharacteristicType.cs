using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class MaterialCharacteristicType : ObjectGraphType<MaterialCharacteristicDomainModel>
    {
        public MaterialCharacteristicType()
        {
            Name = "Material Characteristic";
            Description = "Material characteristic";
            Field(m => m.MaterialCharacteristicCode, nullable: true);
            Field(m => m.MaterialCharacteristicDescription, nullable: true);
        }
    }
}
