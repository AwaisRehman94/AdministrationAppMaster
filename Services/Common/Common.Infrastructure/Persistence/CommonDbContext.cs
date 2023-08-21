﻿
using Microsoft.EntityFrameworkCore;

using Common.Domain.Entities;

namespace Common.Infrastructure.Persistence
{
    public class CommonDbContext : DbContext
    {
        public CommonDbContext(DbContextOptions<CommonDbContext> options) : base(options)
        {
        }

        public DbSet<AutoleasingBenefit> AutoleasingBenefit { get; set; }
        public DbSet<AutoleasingDeductible> AutoleasingDeductibles { get; set; }
    }
}