
using Inquiry.Domain.Entities;

namespace Inquiry.Application.Common.Interfaces
{
    public interface IAuthorizationService
    {
        Task<AspNetUserModel> GetUserByEmailAsync(string email);
    }
}