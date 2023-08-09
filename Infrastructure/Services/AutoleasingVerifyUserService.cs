using Inquiry.Application.Common.Interfaces;
using Inquiry.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiry.Infrastructure.Services
{
    public class AutoleasingVerifyUserService : IAutoleasingVerifyUserService
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AutoleasingVerifyUserService(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<int> Insert(AutoleasingVerifyUser autoleasingVerifyUser)
        {
            try
            {
                _applicationDbContext.AutoleasingVerifyUsers.Add(autoleasingVerifyUser);
                var output = await _applicationDbContext.SaveChangesAsync(CancellationToken.None);
                return output;
            }
            catch (Exception exc)
            {
                throw exc;
            }

        }
    }
}