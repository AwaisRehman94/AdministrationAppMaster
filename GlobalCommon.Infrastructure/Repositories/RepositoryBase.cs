
using GlobalCommon.Application.Interfaces.Persistence;

using GlobalCommon.Infrastructure.Persistence;
using IdentityModel;
using Microsoft.EntityFrameworkCore;

namespace GlobalCommon.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly CommonDbContext _commonDbContext;
        public RepositoryBase(CommonDbContext context)
        {
            _commonDbContext = context;
        }

        public IQueryable<T> Table
        {
            get
            {
                return _commonDbContext.Set<T>();
            }
        }

        public IQueryable<T> TableNoTracking
        {
            get
            {
                return _commonDbContext.Set<T>().AsNoTracking();
            }
        }


        public async Task DeleteAsync(T entity)
        {
            _commonDbContext.Set<T>().Remove(entity);
            await _commonDbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(IEnumerable<T> entities)
        {
            _commonDbContext.Set<T>().RemoveRange(entities);
            await _commonDbContext.SaveChangesAsync();

        }

        public async Task InsertAsync(T entity)
        {
            _commonDbContext.Set<T>().Add(entity);
            await _commonDbContext.SaveChangesAsync();
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            _commonDbContext.Set<T>().AddRange(entities);
            await _commonDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _commonDbContext.Set<T>().Update(entity);
            await _commonDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(IEnumerable<T> entities)
        {
            _commonDbContext.Set<T>().UpdateRange(entities);
            await _commonDbContext.SaveChangesAsync();
        }
    }
}