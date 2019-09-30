using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class CustomerType : ObjectGraphType<CustomerDomainModel>
    {
        public CustomerType()
        {
            Name = "Customer";
            Description = "A customer";
            Field(c => c.CustomerId, nullable: false).Description("The customer id");
            Field(c => c.CustomerNumber, nullable: false).Description("The customer number");
            Field(c => c.CustomerName, nullable: false).Description("The name of the customer");
        }
    }
}
