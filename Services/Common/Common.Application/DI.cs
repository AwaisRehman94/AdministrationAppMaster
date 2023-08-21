
using System.Reflection;
using Common.Application.Common.Interfaces;
using Common.Application.Services;
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
