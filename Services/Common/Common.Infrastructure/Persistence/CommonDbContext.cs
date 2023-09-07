
using Microsoft.EntityFrameworkCore;

using Common.Domain.Entities;
using Common.Domain.DomainEntities.Entities.DomainEntities;




namespace Common.Infrastructure.Persistence
{
    public partial class CommonDbContext : DbContext
    {
    
        public CommonDbContext(DbContextOptions<CommonDbContext> options) : base(options)
        {

        }

        public DbSet<AutoleasingBenefit> AutoleasingBenefit { get; set; }
       
        public  DbSet<AutoleasingDeductibles> AutoleasingDeductibles { get; set; }

        public  DbSet<NajmStatus> NajmStatus { get; set; }

    }
}