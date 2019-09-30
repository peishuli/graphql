using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class DeliveryType : ObjectGraphType<DeliveryDomainModel>
    {
        public DeliveryType()
        {
            Name = "Delivery";
            Description = "An order delivery";
            Field<DeliveryStatusEnum>("DeliveryStatus", "An enum for delivery status");
            Field(
                name: "DeliveryEvents",
                type: typeof(DeliveryEventType),
                resolve: context => context.Source.DeliveryEvents
            );
            Field(
                name: "LinkedDocuments",
                type: typeof(ListGraphType<LinkedDocumentType>),
                resolve: context => context.Source.LinkedDocuments
            );
            Field(
                name: "Links",
                type: typeof(ListGraphType<LinkType>),
                resolve: context => context.Source.Links
            );
            Field(d => d.ShippingType, nullable: true);
            Field(d => d.ShippingDateUtc, nullable: true);
        }
    }
}
