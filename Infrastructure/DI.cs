
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Inquiry.Application.Common.Interfaces;

using Inquiry.Infrastructure.Persistence;
using Inquiry.Infrastructure.Persistence.Entities;
using Inquiry.Infrastructure.Services;
using Inquiry.Infrastructure.Repositories;

namespace Inquiry.Infrastructure
{
    public static class DI
    {

        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetSection("DbProvider").Value == "MSSQLServer")
            {
                services.AddDbContext<ApplicationDbContext>(
                    options =>
                    options.UseSqlServer(configuration.GetConnectionString("MSSQLServer_DefaultConnection"),
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            }
            else
            {
                throw new Exception("Persistence init Exception");
            }

            services.AddDefaultIdentity<AspNetUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddIdentityServer().AddApiAuthorization<AspNetUser, ApplicationDbContext>();

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
            
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IAutoLeasingUserService, AutoLeasingUserService>();
            services.AddTransient<IAutoleasingVerifyUserService, AutoleasingVerifyUserService>();
            services.AddTransient<IAutoleasingBenefitRepository, BenefitRepository>();

            services.AddAuthentication();// .AddIdentityServerJwt();

            services.AddAuthorization();
        }
    }
}