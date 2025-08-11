using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftwareHouse.Application.UseCases.Budgets.Create;
using SoftwareHouse.Application.UseCases.Budgets.Get;
using SoftwareHouse.Application.UseCases.Budgets.Update;
using SoftwareHouse.Application.UseCases.Costs.Create;
using SoftwareHouse.Application.UseCases.Costs.Get;
using SoftwareHouse.Application.UseCases.Costs.Update;
using SoftwareHouse.Application.UseCases.Customers.Create;
using SoftwareHouse.Application.UseCases.Customers.Get;
using SoftwareHouse.Application.UseCases.Customers.Update;
using SoftwareHouse.Application.UseCases.Projects.Create;
using SoftwareHouse.Application.UseCases.Projects.Get;
using SoftwareHouse.Application.UseCases.Projects.Update;
using SoftwareHouse.Infrastructure;

namespace SoftwareHouse.Application
{
    public static class Setup
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICustomerCreateUseCase, CustomerCreateUseCase>();
            services.AddTransient<ICustomerUpdateUseCase, CustomerUpdateUseCase>();
            services.AddTransient<ICustomerGetUseCase, CustomerGetUseCase>();

            services.AddTransient<IBudgetUpdateUseCase, BudgetUpdateUseCase>();
            services.AddTransient<IBudgetGetUseCase, BudgetGetUseCase>();
            services.AddTransient<IBudgetCreateUseCase, BudgetCreateUseCase>();

            services.AddTransient<ICostsUpdateUseCase, CostsUpdateUseCase>();
            services.AddTransient<ICostsGetUseCase, CostsGetUseCase>();
            services.AddTransient<ICostsCreateUseCase, CostsCreateUseCase>();

            services.AddTransient<IProjectCreateUseCase, ProjectCreateUseCase>();
            services.AddTransient<IProjectGetUseCase, ProjectGetUseCase>();
            services.AddTransient<IProjectUpdateUseCase, ProjectUpdateUseCase>();

            services.AddInfrastructure(configuration);
        }

    }
}
