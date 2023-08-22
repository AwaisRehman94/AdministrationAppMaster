
using Identity.Domain.Entities;
using Identity.Application.Common.Interfaces;
using Identity.Infrastructure.Persistence;

using Microsoft.EntityFrameworkCore;

namespace Identity.Infrastructure.Repositories
{
    public class IdentityRepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly IdentityDbContext _applicationDbContext;
        public IdentityRepositoryBase(IdentityDbContext context)
        {
            _applicationDbContext = context;
        }

        public IQueryable<T> Table
        {
            get
            {
                return _applicationDbContext.Set<T>();
            }
        }

        public IQueryable<T> TableNoTracking
        {
            get
            {
                return _applicationDbContext.Set<T>().AsNoTracking();
            }
        }


        public async Task DeleteAsync(T entity)
        {
            _applicationDbContext.Set<T>().Remove(entity);
            await _applicationDbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(IEnumerable<T> entities)
        {
            _applicationDbContext.Set<T>().RemoveRange(entities);
            await _applicationDbContext.SaveChangesAsync();

        }

        public async Task InsertAsync(T entity)
        {
            if (!(entity is ILookupTable))
            {
                _applicationDbContext.Set<T>().Add(entity);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {

            foreach (var item in entities)
            {
                if (!(item is ILookupTable))
                {
                    _applicationDbContext.Set<T>().Add(item);
                }
            }
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _applicationDbContext.Set<T>().Update(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(IEnumerable<T> entities)
        {
            _applicationDbContext.Set<T>().UpdateRange(entities);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
