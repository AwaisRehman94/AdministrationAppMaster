
using Duende.IdentityServer.EntityFramework.Options;

using Identity.Domain.Entities;
using Identity.Infrastructure.Persistence.Entities;

using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Identity.Infrastructure.Persistence
{
    public class IdentityDbContext : ApiAuthorizationDbContext<AspNetUser>
    {
        public IdentityDbContext(
            DbContextOptions<IdentityDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

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