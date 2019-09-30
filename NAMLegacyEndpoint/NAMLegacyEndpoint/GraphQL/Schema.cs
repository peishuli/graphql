using GraphQL;
using GraphQL.Types;

namespace NAMLegacyEndpoint.GraphQL
{
    public class NAMLegacySchema : Schema
    {
        public NAMLegacySchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<NAMLegacyQuery>();
        }
    }
}
