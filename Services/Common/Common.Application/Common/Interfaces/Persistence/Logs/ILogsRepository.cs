namespace Common.Application.Common.Interfaces.Persistence.Logs
{
    /// <summary>
    /// Db Logging specific classes should inherit from this interface.
    /// i.e.LoginRequestLog table for example
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILogsRepository<T> : IRepository<T>
    {
    }
}