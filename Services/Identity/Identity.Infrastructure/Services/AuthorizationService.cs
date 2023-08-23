
using Microsoft.AspNetCore.Identity;

using Identity.Application.Common.Interfaces;
using Identity.Application.Common.Models;
using Identity.Infrastructure.Persistence.Entities;
 
namespace Identity.Infrastructure.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly UserManager<AspNetUser> _userManager;

        public AuthorizationService(UserManager<AspNetUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<GetAuthorizedUserByEmailResponse> GetUserByEmailAsync(string email)
        {
            GetAuthorizedUserByEmailResponse um = new GetAuthorizedUserByEmailResponse();
            var result = await _userManager.FindByEmailAsync(email);
            if (result == null)
                return null;

            um.Email = result.Email;
            um.Id = result.Id;
            return um;
        }

        public async Task<GetAuthorizedUserByIdResponse> GetUserByIdAsync(string id)
        {
            GetAuthorizedUserByIdResponse getAuthorizedUserByIdResponse = new GetAuthorizedUserByIdResponse();
            
            var result = await _userManager.FindByIdAsync(id);

            if (result == null)
                return null;

            getAuthorizedUserByIdResponse.Email = result.Email!;
            getAuthorizedUserByIdResponse.Id = result.Id;
            
            return getAuthorizedUserByIdResponse;
        }
    }
}