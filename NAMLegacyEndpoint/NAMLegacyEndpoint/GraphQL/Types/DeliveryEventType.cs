using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class DeliveryEventType : ObjectGraphType<DeliveryEventDomainModel>
    {
        public DeliveryEventType()
        {
            Name = "Delivery Event";
            Description = "A delivery event";
            Field(f => f.LoadStartedUtc, nullable: true);
            Field(f => f.LoadFinishedUtc, nullable: true);
            Field(f => f.ArrivedUtc, nullable: true);
            Field(f => f.UnloadStartedUtc, nullable: true);
            Field(f => f.UnloadFinishedUtc, nullable: true);
        }
    }
}
