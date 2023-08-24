
using Common.Domain.Entities.LogEntities;
using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.Persistence
{
    public class TameenkLog : DbContext
    {
        public TameenkLog(DbContextOptions<TameenkLog> options) : base(options)
        {
        }

        public DbSet<LoginRequestsLog> LoginRequestsLog { get; set; }
    }
}