
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Application
{
    public static class DI
    {
        public static IServiceCollection AddCommonApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
