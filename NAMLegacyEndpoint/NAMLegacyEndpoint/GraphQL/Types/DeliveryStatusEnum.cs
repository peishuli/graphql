using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class DeliveryStatusEnum : EnumerationGraphType
    {
        public DeliveryStatusEnum()
        {
            Name = "DeliveryStatus";
            AddValue("Unknown", "Unknown", 0);
            AddValue("Open", "Open", 1);
            AddValue("WaitingForLoad", "WaitingForLoad", 2);
            AddValue("Loading", "Loading", 3);
            AddValue("InTransit", "InTransit", 4);
            AddValue("WaitingForUnload", "WaitingForUnload", 5);
            AddValue("Unloading", "Unloading", 6);
            AddValue("Unloaded", "Unloaded", 7);
            AddValue("Completed", "Completed", 8);
            AddValue("Returned", "Returned", 9);
            AddValue("Invoiced", "Invoiced", 10);
            AddValue("Cancelled", "Cancelled", 11);
            AddValue("Loaded", "Loaded", 12);

        }
    }
}
