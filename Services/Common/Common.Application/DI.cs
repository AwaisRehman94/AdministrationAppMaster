
using System.Reflection;
using Common.Application.Common.Interfaces;
using Common.Application.Common.Interfaces.Persistence.Logs;
using Common.Application.Services;
using Common.Application.Services.Logs;
using Common.Domain.Entities.LogEntities;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Application
{
    public static class DI
    {
        public static IServiceCollection AddCommonApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<ITokenService, TokenService>();
            return services;
        }
    }
}
