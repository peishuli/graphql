using GraphQL.Types;
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

            Field<ListGraphType<OrderType>>(
                "orders",
                resolve: context => data.GetOrders());

            Field<OrderType>(
               "order",
               //TODO: add optional params
               arguments: new QueryArguments(
                   new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "orderId", Description = "id of the order" }
                   //, new QueryArgument<StringGraphType> { Name = "projectId", Description = "id of the project" }
               ),
               //resolve: context => data.GetOrderById(context.GetArgument<string>("orderId"), context.GetArgument<string>("projectId"))
               resolve: context => data.GetOrderById(context.GetArgument<string>("orderId"))
            );

        }
    }
}
