
using Inquiry.Domain.Entities;

namespace Inquiry.Application.Common.Interfaces
{
    public interface IAutoleasingVerifyUserService
    {
        Task<int> Insert(AutoleasingVerifyUser autoleasingVerifyUser);
    }
}
