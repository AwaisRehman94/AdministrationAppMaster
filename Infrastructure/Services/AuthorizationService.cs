
using Inquiry.Application.Common.Interfaces;
using Inquiry.Domain.Entities;
using Inquiry.Infrastructure.Persistence.Entities;

using Microsoft.AspNetCore.Identity;

namespace Inquiry.Infrastructure.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly UserManager<AspNetUser> _userManager;

        public AuthorizationService(UserManager<AspNetUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<AspNetUserModel> GetUserByEmailAsync(string email)
        {
            try
            {
                AspNetUserModel um = new AspNetUserModel();
                var result = await _userManager.FindByEmailAsync(email);
                if (result == null)
                    return null;

                um.Email = result.Email;
                um.Id = result.Id;
                return um;
            }
            catch (Exception exc)
            {
                throw exc;
            }

        }
    }
}