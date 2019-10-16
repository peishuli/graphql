using Flurl;
using Flurl.Http;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using HeidelbergCement.Foundation.Common.Interfaces.Enums;
using System;
using System.Collections.Generic;

namespace NAMLegacyEndpoint.GraphQL
{
    public class NAMLegacyData
    {
        //https://www.hanselman.com/blog/UsingFlurlToEasilyBuildURLsAndMakeTestableHttpClientCallsInNET.aspx

        const string baseUrl = "https://mock-services-qa.apps.dev01-emea.hck8s.me";
        public IEnumerable<OrderDomainModel> GetOrders (
            DateTime? startDate = null, 
            DateTime? endDate = null, 
            string siteId = null, 
            string customerId = null,
            string orderNumber = null,
            string projectId = null,
            OrderStatus? orderStatus = null
            )
        {
            var url = baseUrl.AppendPathSegments("api", "orders");
            if (startDate != null)
                url.QueryParams.Add("startDate", startDate);

            if (endDate != null)
                url.QueryParams.Add("endDate", endDate);

            if (!string.IsNullOrEmpty(siteId))
                url.QueryParams.Add("siteId", siteId);

            if (!string.IsNullOrEmpty(siteId))
                url.QueryParams.Add("customerId", customerId);

            if (!string.IsNullOrEmpty(siteId))
                url.QueryParams.Add("orderNumber", orderNumber);

            if (!string.IsNullOrEmpty(projectId))
                url.QueryParams.Add("projectId", projectId);

            if (orderStatus != null)
                url.QueryParams.Add("orderStatus", orderStatus);

            return url
                .GetJsonAsync<IEnumerable<OrderDomainModel>>().Result;
        }

        public OrderDomainModel GetOrderById(string orderId)
        {
            return baseUrl.AppendPathSegments("api", "orders", orderId)
               .GetJsonAsync<OrderDomainModel>().Result;

        }
    }
}
