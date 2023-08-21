
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Common.Application.Common.Interfaces.Persistence;
using Common.Infrastructure.Persistence;
using Common.Infrastructure.Repositories;

namespace Common.Infrastructure
{
    public static class DI
    {
        public static void AddCommonPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetSection("DbProvider").Value == "MSSQLServer")
            {
                services.AddDbContext<CommonDbContext>(
                    options =>
                    options.UseSqlServer(configuration.GetConnectionString("MSSQLServer_DefaultConnection"),
                    builder => builder.MigrationsAssembly(typeof(CommonDbContext).Assembly.FullName)));
            }
            else
            {
                throw new Exception("Persistence init Exception");
            }

            services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
        }
    }
}