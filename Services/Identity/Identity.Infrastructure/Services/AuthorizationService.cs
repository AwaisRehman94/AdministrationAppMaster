
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

        public async Task<IDictionary<string, string>> GetUserByIdAsync(string id)
        {
            // GetAuthorizedUserByIdResponse getAuthorizedUserByIdResponse = new GetAuthorizedUserByIdResponse();

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            var result = await _userManager.FindByIdAsync(id);

            if (result == null)
                return null;

            keyValuePairs.Add("Email", result.Email!);
            keyValuePairs.Add("Id", result.Id);
            return keyValuePairs;
        }
    }
}