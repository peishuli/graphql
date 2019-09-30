using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System.Linq;

using HeidelbergCement.Foundation.Common.Interfaces.DTOs;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    //ref: https://github.com/graphql-dotnet/graphql-dotnet/issues/818
    //     https://medium.com/swlh/the-no-bullsh-t-guide-to-graphql-in-net-core-9df290be7f27
    public class OrderType : ObjectGraphType<OrderDomainModel>
    {
        public OrderType()
        {
            Name = "Order";
            Description = "A Order from NAM Legacy system";
            Field(
                name: "Customer",
                type: typeof(CustomerType),
                resolve: context => context.Source.Customer
            );
            Field(o => o.ShippingDateUtc, nullable: true);
            Field(o => o.PlacedDateUtc, nullable: true);
            Field(
                name: "ShippingAddress",
                type: typeof(SiteType),
                resolve: context => context.Source.ShippingAddress
            );

            Field(
                name: "LineItems",
                type: typeof(ListGraphType<LineItemType>),
                resolve: context => context.Source.LineItems

            );

            Field(
                name: "SupplementItems",
                type: typeof(ListGraphType<SupplementItemType>),
                resolve: context => context.Source.SupplementItems
            );

            Field(
               name: "Schedules",
               type: typeof(ListGraphType<ScheduleType>),
               resolve: context => context.Source.Schedules
            );

            Field(
                name: "Deliveries",
                type: typeof(ListGraphType<DeliveryType>),
                resolve: context => context.Source.Deliveries
            );

            Field(
                name: "DeliveryProgress",
                type: typeof(DeliveryProgressType),
                resolve: context => context.Source.DeliveryProgress
            );

            Field(o => o.OrderId);
            Field(o => o.OrderNumber);
            Field(o => o.Customer.CustomerId);
            Field(o => o.TruckId);
            Field(o => o.ProjectNumber);
            Field(o => o.ProjectId);
            Field<OrderStatusEnum>("OrderStatus", "An enum for order status");
            Field(o => o.IsHalted, nullable: true);
            Field(o => o.ShippingType);
            Field(o => o.CustomerReference);
        }
    }
}
