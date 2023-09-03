
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Identity.Application.Common.Interfaces;
using Identity.Application.Common.Models;
using Identity.Domain.Entities;
using Common.Application.Common.Interfaces.Persistence;

namespace Identity.Application.Services
{
    internal class AutoLeasingUserService : IAutoLeasingUserService
    {
        private readonly IIdentityRepository<AutoleasingUser> _repository;
        private readonly IMapper _mapper;
        public AutoLeasingUserService(IIdentityRepository<AutoleasingUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAutoLeasingUserByEmailResponse> GetUserByEmailAsync(string email)
        {
            try
            {
                var result = await _repository.Table.Where(x => x.Email == email).ProjectTo<GetAutoLeasingUserByEmailResponse>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
                return result;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
