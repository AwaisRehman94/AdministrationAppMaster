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
    public class AutoLeasingUserService : IAutoLeasingUserService
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AutoLeasingUserService(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<AutoleasingUser> GetUserByEmailAsync(string email)
        {
            try
            {
                var result = await _applicationDbContext.AutoleasingUsers.Where(x => x.Email == email).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception exc)
            {
                throw exc;
            }

        }
    }
}