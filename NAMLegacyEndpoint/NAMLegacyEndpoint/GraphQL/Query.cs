using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.Enums;
using NAMLegacyEndpoint.GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAMLegacyEndpoint.GraphQL
{
    public class NAMLegacyQuery : ObjectGraphType<object>
    {
        public NAMLegacyQuery(NAMLegacyData data)
        {
            Name = "Query";
            
            //endpoint: /orders 
            Field<ListGraphType<OrderType>> (
                "orders",
                arguments: new QueryArguments (
                    new QueryArgument<DateGraphType> { Name = "startDate", Description = "The starting date of orders" }
                    , new QueryArgument<DateGraphType> { Name = "endDate", Description = "The ending date of orders" }
                    , new QueryArgument<StringGraphType> { Name = "siteId", Description = "The id of the site" }
                    , new QueryArgument<StringGraphType> { Name = "customerId", Description = "The id of the customer" }
                    , new QueryArgument<StringGraphType> { Name = "orderNumber", Description = "The order number" }
                    , new QueryArgument<StringGraphType> { Name = "projectId", Description = "The id of the project" }
                    , new QueryArgument<EnumerationGraphType> { Name = "orderStatus", Description = "The order status" }
                ),

                resolve: context =>
                {
                    var startDate = context.GetArgument<DateTime?>("startDate");
                    var endDate = context.GetArgument<DateTime?>("endDate");
                    var siteId = context.GetArgument<string>("siteId");
                    var customerId = context.GetArgument<string>("customerId");
                    var orderNumber = context.GetArgument<string>("orderNumber");
                    var projectId =context.GetArgument<string>("projectId");
                    var orderStatus = context.GetArgument<OrderStatus?>("orderStatus");
                    return data.GetOrders(startDate, endDate, siteId, customerId, orderNumber, projectId, orderStatus);
                }
            );

            //endpoint: /orders/{id} 
            Field<OrderType>(
               "order",
               arguments: new QueryArguments(
                   new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "orderId", Description = "The id of the order" }               
               ),
               resolve: context => data.GetOrderById(context.GetArgument<string>("orderId"))
            );

        }
    }
}
