
using Common.Application.Common.Interfaces.Persistence;
using Identity.Application.Common.Interfaces;
using Identity.Domain.Entities;

namespace Identity.Application.Services
{
    public class AutoleasingVerifyUserService : IAutoleasingVerifyUserService
    {
        private readonly IIdentityRepository<AutoleasingVerifyUser> _repository;
        public AutoleasingVerifyUserService(IIdentityRepository<AutoleasingVerifyUser> repository)
        {
            _repository = repository;
        }
        public async Task InsertAsync(AutoleasingVerifyUser autoleasingVerifyUser)
        {
            await _repository.InsertAsync(autoleasingVerifyUser);
        }
    }
}