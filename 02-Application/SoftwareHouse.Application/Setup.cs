using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SoftwareHouse.Application
{
    public static class Setup
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register application services, use cases, and other dependencies here
            // Example:

            //services.AddScoped<ICustomerCreateUseCase, CustomerCreateUseCase>();

            //services.AddScoped<ICustomerGetUseCase, CustomerGetUseCase>();
        }

    }
}
