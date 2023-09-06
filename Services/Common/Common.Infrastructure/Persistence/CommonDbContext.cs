
using Microsoft.EntityFrameworkCore;

using Common.Domain.Entities;
using Common.Domain.DomainEntities.Entities.DomainEntities;

namespace Common.Infrastructure.Persistence
{
    public class AutoLeasingServiceContext : DbContext
    {
        public AutoLeasingServiceContext(DbContextOptions<AutoLeasingServiceContext> options) : base(options)
        {
        }

        public DbSet<AutoleasingBenefit> AutoleasingBenefit { get; set; }
        public DbSet<AutoleasingDeductibles> AutoleasingDeductibles { get; set; }
    }
}