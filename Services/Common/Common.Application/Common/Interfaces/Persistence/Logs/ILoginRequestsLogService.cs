
using Common.Domain.Entities.LogEntities;

namespace Common.Application.Common.Interfaces.Persistence.Logs
{
    public interface ILogService<T>
    {
         Task<Boolean> LogAsync(T log);
    }
}