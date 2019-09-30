using Flurl;
using Flurl.Http;
using HeidelbergCement.Foundation.Common.Interfaces.DomainModels;
using System.Collections.Generic;

namespace NAMLegacyEndpoint.GraphQL
{
    public class NAMLegacyData
    {
        const string baseUrl = "https://mock-services-dev.apps.dev01-emea.hck8s.me";
        public IEnumerable<OrderDomainModel> GetOrders()
        {
            return baseUrl.AppendPathSegments("api", "orders")
                .GetJsonAsync<IEnumerable<OrderDomainModel>>().Result;
        }

        public OrderDomainModel GetOrderById(string orderId)
        {
            return baseUrl.AppendPathSegments("api", "orders", orderId)
               .GetJsonAsync<OrderDomainModel>().Result;

        }
    }
}
