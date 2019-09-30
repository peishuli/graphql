using System.Security.Claims;

namespace NAMLegacyEndpoint.GraphQL
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
