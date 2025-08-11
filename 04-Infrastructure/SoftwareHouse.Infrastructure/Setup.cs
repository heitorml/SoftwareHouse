using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace SoftwareHouse.Infrastructure
{
    public static class Setup
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoClient = new MongoClient(configuration["MongoDb:ConnectionString"]);
            var database = mongoClient.GetDatabase(configuration["MongoDb:DatabaseName"]);

            services.AddSingleton<IMongoClient>(mongoClient);
            services.AddSingleton(database);
        }
    }
}
