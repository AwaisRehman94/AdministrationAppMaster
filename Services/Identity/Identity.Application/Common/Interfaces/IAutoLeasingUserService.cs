
using Identity.Application.Common.Models;

namespace Identity.Application.Common.Interfaces
{
    public interface IAutoLeasingUserService
    {
        Task<GetAutoLeasingUserByEmailResponse> GetUserByEmailAsync(string email);
    }
}
