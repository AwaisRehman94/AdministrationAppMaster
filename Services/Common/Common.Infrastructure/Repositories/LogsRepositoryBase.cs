
using Common.Application.Common.Interfaces.Persistence;
using Common.Application.Common.Interfaces.Persistence.Logs;
using Common.Domain.Entities;
using Common.Infrastructure.Persistence;

using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.Repositories
{
    public class LogsRepositoryBase<T> : ILogsRepository<T> where T : class
    {
        protected readonly TameenkLog _tameenkDbContext;
        public LogsRepositoryBase(TameenkLog context)
        {
            _tameenkDbContext = context;
        }

        public IQueryable<T> Table
        {
            get
            {
                return _tameenkDbContext.Set<T>();
            }
        }

        public IQueryable<T> TableNoTracking
        {
            get
            {
                return _tameenkDbContext.Set<T>().AsNoTracking();
            }
        }


        public async Task DeleteAsync(T entity)
        {
            _tameenkDbContext.Set<T>().Remove(entity);
            await _tameenkDbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(IEnumerable<T> entities)
        {
            _tameenkDbContext.Set<T>().RemoveRange(entities);
            await _tameenkDbContext.SaveChangesAsync();

        }

        public async Task InsertAsync(T entity)
        {
            if (!(entity is ILookupTable))
            {
                _tameenkDbContext.Set<T>().Add(entity);
                await _tameenkDbContext.SaveChangesAsync();
            }
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                if(! (item is ILookupTable))
                {
                    _tameenkDbContext.Set<T>().Add(item);
                }
            }
            await _tameenkDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _tameenkDbContext.Set<T>().Update(entity);
            await _tameenkDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(IEnumerable<T> entities)
        {
            _tameenkDbContext.Set<T>().UpdateRange(entities);
            await _tameenkDbContext.SaveChangesAsync();
        }
    }
}