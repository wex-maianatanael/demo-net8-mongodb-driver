using Demo.Infra.Repository.Context;
using Demo.Infra.Repository.Settings;

namespace Demo.Api.Configuration
{
    public static class MongoDbConfiguration
    {
        public static IServiceCollection AddMongoDbConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            // todo: test it. Not sure yet if we really need this line 11
            services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
            services.AddSingleton<MongoDbContext>();

            return services;
        }
    }
}
