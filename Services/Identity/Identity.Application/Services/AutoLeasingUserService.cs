﻿
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Identity.Application.Common.Interfaces;
using Identity.Application.Common.Models;
using Identity.Domain.Entities;

namespace Identity.Application.Services
{
    internal class AutoLeasingUserService : IAutoLeasingUserService
    {
        private readonly IRepository<AutoleasingUser> _repository;
        private readonly IMapper _mapper;
        public AutoLeasingUserService(IRepository<AutoleasingUser> repository, IMapper mapper)
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
