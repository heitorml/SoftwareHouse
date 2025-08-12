using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftwareHouse.Infrastructure.Repositories;

namespace SoftwareHouse.Infrastructure
{
    public static class Setup
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {


            //var mongoClient = new MongoClient(configuration["MongoDb:ConnectionString"]);
            //var database = mongoClient.GetDatabase(configuration["MongoDb:DatabaseName"]);
            //var db = SoftwareHouseDbContext.Create(database);


            ////services.AddSingleton<IMongoClient>(mongoClient);
            ////services.AddSingleton(database);
            //services.AddDbContext<SoftwareHouseDbContext>
            // (options => options.UseMongoDB(configuration["MongoDb:ConnectionString"], configuration["MongoDb:DatabaseName"]));




            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
