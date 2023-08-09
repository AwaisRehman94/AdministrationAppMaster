using Inquiry.Domain.Entities;

using Inquiry.Application.Common.Interfaces;
using Duende.IdentityServer.EntityFramework.Options;

using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Inquiry.Infrastructure.Persistence.Entities;

namespace Inquiry.Infrastructure.Persistence
{
    //
    public class ApplicationDbContext : ApiAuthorizationDbContext<AspNetUser>, IApplicationDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<AutoleasingBenefit> AutoleasingBenefit => Set<AutoleasingBenefit>();

        public DbSet<AutoleasingDeductible> AutoleasingDeductibles => Set<AutoleasingDeductible>();

        public DbSet<AutoleasingUser> AutoleasingUsers => Set<AutoleasingUser>();

        public DbSet<AutoleasingVerifyUser> AutoleasingVerifyUsers => Set<AutoleasingVerifyUser>();

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}