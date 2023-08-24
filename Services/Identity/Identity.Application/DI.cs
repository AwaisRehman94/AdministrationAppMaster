
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using MediatR;

using Identity.Application.Features.Authorization.Queries;
using Identity.Application.Common.Interfaces;
using Identity.Application.Services;
using Identity.Application.Common.Behaviours;
using Common.Application.Common.Interfaces;
using Common.Application.Services;
namespace Identity.Application
{
    public static class DI
    {
        public static IServiceCollection AddIdentityApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            services.AddScoped<IValidator<LoginRequest>, LoginRequestValidator>();
            services.AddTransient<IAutoLeasingUserService, AutoLeasingUserService>();
            services.AddTransient<IAutoleasingVerifyUserService, AutoleasingVerifyUserService>();
            services.AddScoped<IValidator<LoginRequest>, LoginRequestValidator>();

            //services.AddTransient<ITokenService, TokenService>();


            // services.AddScoped<IDeductibleService, DeductibleService>();
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehaviour<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));


            return services;
        }
    }
}