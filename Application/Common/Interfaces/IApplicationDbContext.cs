
using Microsoft.EntityFrameworkCore;

using Inquiry.Domain.Entities;

namespace Inquiry.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<AutoleasingBenefit> AutoleasingBenefit { get; }
        DbSet<AutoleasingDeductible> AutoleasingDeductibles { get; }
        DbSet<AutoleasingUser> AutoleasingUsers { get; }
        DbSet<AutoleasingVerifyUser> AutoleasingVerifyUsers { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
