using GlobalCommon.Application.Interfaces.Persistence;
using GlobalCommon.Infrastructure.Persistence;
using GlobalCommon.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalCommon.Infrastructure
{
    public static class DI
    {
        public static void AddGlobalCommonPersistence(this IServiceCollection services, IConfiguration configuration)
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

            services.AddTransient(typeof(IRepository<>), typeof(RepositoryBase<>));
        }
    }
}