
using Common.Application.Common.Interfaces.Persistence;
 using Common.Domain.Entities;
 
using Microsoft.EntityFrameworkCore;
using CommonDbContext = Common.Infrastructure.Persistence.CommonDbContext;

namespace Common.Infrastructure.Repositories
{
    public class CommonRepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly CommonDbContext _commonDbContext;
        public CommonRepositoryBase(CommonDbContext context)
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
            if (!(entity is ILookupTable))
            {
                _commonDbContext.Set<T>().Add(entity);
                await _commonDbContext.SaveChangesAsync();
            }
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                if(! (item is ILookupTable))
                {
                    _commonDbContext.Set<T>().Add(item);
                }
            }
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