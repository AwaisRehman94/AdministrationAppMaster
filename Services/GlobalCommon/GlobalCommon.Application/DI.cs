
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace GlobalCommon.Application
{
    public static class DI
    {
        public static IServiceCollection AddGlobalCommonApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
