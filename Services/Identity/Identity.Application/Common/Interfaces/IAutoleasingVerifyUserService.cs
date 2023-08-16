
using Identity.Domain.Entities;

namespace Identity.Application.Common.Interfaces
{
    public interface IAutoleasingVerifyUserService
    {
        Task InsertAsync(AutoleasingVerifyUser autoleasingVerifyUser);
    }
}