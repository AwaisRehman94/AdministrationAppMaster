
using Microsoft.EntityFrameworkCore;

using GlobalCommon.Domain.Entities;

namespace GlobalCommon.Infrastructure.Persistence
{
    public class CommonDbContext : DbContext
    {
        public CommonDbContext(DbContextOptions<CommonDbContext> options) : base(options)
        {
        }

        public DbSet<AutoleasingBenefit> AutoleasingBenefit { get; set; }

    }
}