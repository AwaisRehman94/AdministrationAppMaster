
using Inquiry.Domain.Entities;

namespace Inquiry.Application.Common.Interfaces
{
    public interface IAutoLeasingUserService
    {
        Task<AutoleasingUser> GetUserByEmailAsync(string email);
    }
}
