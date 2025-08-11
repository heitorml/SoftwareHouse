using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace SoftwareHouse.Infrastructure
{
    public static class Setup
    {
        public static void AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoDb");
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase("SoftwareHouse");

            services.AddSingleton<IMongoClient>(mongoClient);
            services.AddSingleton(database);
        }
    }
}
