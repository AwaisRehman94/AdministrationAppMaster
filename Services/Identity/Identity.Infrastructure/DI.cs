﻿

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Identity.Application.Common.Interfaces;
using Identity.Infrastructure.Persistence;
using Identity.Infrastructure.Services;
using Identity.Infrastructure.Repositories;
using Identity.Infrastructure.Persistence.Entities;
using Common.Application.Common.Interfaces.Persistence;

namespace Identity.Infrastructure
{
    public static class DI
    {
        public static void AddIdentityPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetSection("DbProvider").Value == "MSSQLServer")
            {
                services.AddDbContext<IdentityDbContext>(
                    options =>
                    options.UseSqlServer(configuration.GetConnectionString("MSSQLServer_AutoLeasingService"),
                    builder => builder.MigrationsAssembly(typeof(IdentityDbContext).Assembly.FullName)));
            }
            else
            {
                throw new Exception("Persistence init Exception");
            }
            services.AddDefaultIdentity<AspNetUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<IdentityDbContext>();
            
            services.AddTransient(typeof(IIdentityRepository<>), typeof(IdentityRepositoryBase<>));
            services.AddTransient<IAuthorizationService, AuthorizationService>();
 
            services.AddCors();
            services.AddAuthentication();// .AddIdentityServerJwt();
            services.AddAuthorization();
        }
    }
}