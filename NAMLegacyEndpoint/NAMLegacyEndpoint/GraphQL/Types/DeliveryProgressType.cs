using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class DeliveryProgressType : ObjectGraphType<DeliveryProgressDomainModel>
    {
        public DeliveryProgressType()
        {
            Name = "DeliveryProgress";
            Description = "Delivery progress";
            Field(d => d.ShippedDeliveries, nullable: true);
            Field(d => d.ShippedQuantity, nullable: true, type: typeof(FloatGraphType));
            Field(d => d.ArrivedDeliveries, nullable: true);
            Field(d => d.ArrivedQuantity, nullable: true, type: typeof(FloatGraphType));
            Field(d => d.DeliveredDeliveries, nullable: true);
            Field(d => d.DeliveredQuantity, nullable: true, type: typeof(FloatGraphType));

        }
    }
}
