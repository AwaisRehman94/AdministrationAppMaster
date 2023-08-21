
using Identity.Application.Common.Models;
using Identity.Domain.Entities;

namespace Identity.Application.Common.Interfaces
{
    public interface IAuthorizationService
    {
        Task<GetAuthorizedUserByEmailResponse> GetUserByEmailAsync(string email);
        Task<IDictionary<string,string>> GetUserByIdAsync(string id);
    }
}
