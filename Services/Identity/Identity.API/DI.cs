
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using MediatR;

using Identity.API.Filters;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.AspNetCore;

namespace Identity.API
{
    public static class DI
    {
        public static IServiceCollection AddIdentityAPIServices(this IServiceCollection services)
        {
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddHttpContextAccessor();

            services.AddControllersWithViews(options =>
                options.Filters.Add<ApiExceptionFilterAttribute>())
                    .AddFluentValidation(x => x.AutomaticValidationEnabled = false);

            //Customise default API behaviour
            services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

            return services;
        }
    }
}