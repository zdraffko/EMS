using EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase;

using Microsoft.Extensions.DependencyInjection;

namespace EMS.Core
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddTransient<IPromoteEmployeeInputPort, PromoteEmployeeInteractor>();

            return services;
        }
    }
}
