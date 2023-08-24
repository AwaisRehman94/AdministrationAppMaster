
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Common.Application.Common.Interfaces.Persistence;
using Common.Infrastructure.Persistence;
using Common.Infrastructure.Repositories;
using Common.Application.Common.Interfaces.Persistence.Logs;

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
                    options.UseSqlServer(configuration.GetConnectionString("MSSQLServer_AutoLeasingService"),
                    builder => builder.MigrationsAssembly(typeof(CommonDbContext).Assembly.FullName)));

                services.AddDbContext<TameenkLog>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MSSQLServer_AutoLeasingServiceLog"),
                builder => builder.MigrationsAssembly(typeof(TameenkLog).Assembly.FullName)));
            }
            else
            {
                throw new Exception("Persistence init Exception");
            }
            services.AddTransient(typeof(IRepository<>), typeof(CommonRepositoryBase<>));
            services.AddTransient(typeof(ILogsRepository<>), typeof(LogsRepositoryBase<>));
        }
    }
}