using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using HeidelbergCement.Foundation.Common.Interfaces.Enums;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class OrderStatusEnum : EnumerationGraphType //EnumerationGraphType<OrderStatus>
    {
        public OrderStatusEnum()
        {
            {
                Name = "OrderStatus";
                Description = "Available enums for OrderStatus (Preserved, Pending, Confirmed, etc...)";
                AddValue("Reserved", "Reserved", 0);
                AddValue("Pending", "Pending", 1);
                AddValue("Confirmed", "Confirmed", 2);
                AddValue("Cancelled", "Cancelled", 3);
                AddValue("InProgress", "InProgress", 4);
                AddValue("PartiallyShipped", "PartiallyShipped", 5);
                AddValue("Shipped", "Shipped", 6);
                AddValue("PartiallyDelivered", "PartiallyDelivered", 7);
                AddValue("Delivered", "Delivered", 8);

            }
        }
    }
}
