using EMS.Core.Application.Gateways;
using EMS.Core.Application.Infrastructure;
using EMS.Infrastructure.Gateways;
using EMS.Infrastructure.Services;

using Microsoft.Extensions.DependencyInjection;

namespace EMS.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IManagerRepository, ManagerRepository>();

            return services;
        }
    }
}
