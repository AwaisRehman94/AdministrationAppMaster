
using Common.Application.Common.Interfaces.Persistence.Logs;
using Common.Domain.Entities.LogEntities;

namespace Common.Application.Services.Logs
{
    public class LogServiceBase<T> : ILogService<T> where T : class
    {
        private readonly ILogsRepository<T> _repository;

        public LogServiceBase(ILogsRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<bool> LogAsync(T loginRequestsLog)
        {
            try
            {
                await _repository.InsertAsync(loginRequestsLog);
                return true;
            }
            catch (Exception exc)
            {
                return false;
                throw exc;
            }
        }
    }
}