using EMS.Web.Presenters;

using Microsoft.Extensions.DependencyInjection;

namespace EMS.Web
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterWebComponents(this IServiceCollection services)
        {
            services.AddTransient<PromoteEmployeePresenter>();

            return services;
        }
    }
}
