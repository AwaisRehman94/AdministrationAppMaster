
using Identity.Application.Common.Interfaces;
using Identity.Domain.Entities;

namespace Identity.Application.Services
{
    public class AutoleasingVerifyUserService : IAutoleasingVerifyUserService
    {
        private readonly IRepository<AutoleasingVerifyUser> _repository;
        public AutoleasingVerifyUserService(IRepository<AutoleasingVerifyUser> repository)
        {
            _repository = repository;
        }
        public async Task InsertAsync(AutoleasingVerifyUser autoleasingVerifyUser)
        {
            await _repository.InsertAsync(autoleasingVerifyUser);
        }
    }
}