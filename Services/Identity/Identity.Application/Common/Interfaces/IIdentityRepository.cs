

using Common.Application.Common.Interfaces.Persistence;

namespace Identity.Application.Common.Interfaces
{
    /// <summary>
    /// Identity specific classes should inherit from this interface.
    /// </summary>
    public interface IIdentityRepository<T> : IRepository<T>
    {
 
    }
}