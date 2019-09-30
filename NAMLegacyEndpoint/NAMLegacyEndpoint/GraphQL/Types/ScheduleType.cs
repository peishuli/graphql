using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;

namespace NAMLegacyEndpoint.GraphQL.Types
{
    public class ScheduleType : ObjectGraphType<ScheduleDomainModel>
    {
        public ScheduleType()
        {
            Name = "Schedule";
            Description = "A schedule";
            Field(s => s.ScheduleStartDateUtc, nullable: true);
            Field(s => s.ScheduleEndDateUtc, nullable: true);
            Field(s => s.ArrivalSpacing, nullable: true);
            Field(s => s.ScheduleNumber, nullable: true);
            Field(s => s.ScheduleQuantity, nullable: true);
            Field(s => s.QuantityChangeExpected, nullable: true);
            Field(s => s.HoldQuantity, nullable: true);
            Field(s => s.QuantityPerHour, nullable: true);

        }
    }
}
