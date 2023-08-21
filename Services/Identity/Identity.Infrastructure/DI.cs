

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Identity.Infrastructure.Persistence;
using Identity.Infrastructure.Services;
using Identity.Application.Common.Interfaces;
using Identity.Infrastructure.Repositories;
using Identity.Infrastructure.Persistence.Entities;

namespace Identity.Infrastructure
{
    public static class DI
    {
        public static void AddIdentityPersistence(this IServiceCollection services, IConfiguration configuration)
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
            
            services.AddTransient(typeof(IRepository<>), typeof(RepositoryBase<>));
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            // services.AddTransient<ITokenService, TokenService>();

            services.AddCors();
            services.AddAuthentication();// .AddIdentityServerJwt();
            services.AddAuthorization();
        }
    }
}