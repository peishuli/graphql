using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NAMLegacyEndpoint.GraphQL;
using NAMLegacyEndpoint.GraphQL.Types;

namespace NAMLegacyEndpoint
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //TODO: Not sure if we need the following two lines - will figure out later
            //services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            //services.AddSingleton<IDocumentWriter, DocumentWriter>();

            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            services.AddSingleton<NAMLegacyData>();
            services.AddSingleton<NAMLegacyQuery>();

            services.AddSingleton<OrderType>();
            services.AddSingleton<CustomerType>();
            services.AddSingleton<SiteType>();

            services.AddSingleton<LineItemType>();
            
            services.AddSingleton<MaterialCharacteristicType>();
            services.AddSingleton<SupplementItemType>();

            services.AddSingleton<ScheduleType>();

            services.AddSingleton<DeliveryType>();

            services.AddSingleton<DeliveryStatusEnum>();
            services.AddSingleton<DeliveryEventType>();
            services.AddSingleton<LinkedDocumentType>();
            services.AddSingleton<LinkType>();
            
            services.AddSingleton<OrderStatusEnum>();
            
            
            services.AddSingleton<DeliveryProgressType>();

            services.AddSingleton<EnumerationGraphType>();

            services.AddSingleton<ISchema, NAMLegacySchema>();

            services.AddGraphQL(_ =>
            {
                _.EnableMetrics = true;
                _.ExposeExceptions = true;
            })
            .AddUserContextBuilder(httpContext => new GraphQLUserContext { User = httpContext.User });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();

            // add http for Schema at default url /graphql
            app.UseGraphQL<ISchema>("/graphql");

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = "/ui/playground"                
            });

            app.UseHttpsRedirection();            
        }
    }
}
